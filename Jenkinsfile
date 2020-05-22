properties([
	gitLabConnection('gitlab'),
	[$class: 'ParametersDefinitionProperty', 
		parameterDefinitions: [
			[$class: 'StringParameterDefinition', name: 'branch', defaultValue: 'master', description: 'the branch to build'],
			[$class: 'StringParameterDefinition', name: 'apiUrl', defaultValue: 'https://api-qa.aspose.cloud', description: 'api url']
		]
	]

])

def buildCacheImage = "registry.gitlab.com/ivanov.john/test/net"

node('windows2019') {
	try {
		gitlabCommitStatus("checkout") {
			stage('checkout'){
				checkout([$class: 'GitSCM', branches: [[name: params.branch]], doGenerateSubmoduleConfigurations: false, extensions: [[$class: 'LocalBranch', localBranch: "**"]], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '361885ba-9425-4230-950e-0af201d90547', url: 'https://git.auckland.dynabic.com/words-cloud/words-cloud-dotnet.git']]])
				bat 'git clean -fdx'
			}
		}
		gitlabCommitStatus("build") {
			stage('build') {
				withCredentials([usernamePassword(credentialsId: 'cc2e3c9b-b3da-4455-b702-227bcce18895', usernameVariable: 'dockerrigistry_login', passwordVariable: 'dockerregistry_password')]) {
					bat 'docker login -u "%dockerrigistry_login%" -p "%dockerregistry_password%" registry.gitlab.com'
				}
				bat (script: "docker pull ${buildCacheImage}")
				bat (script: "docker build scripts -f scripts\\build.Dockerfile -t netsdkbuild --cache-from=${buildCacheImage} -t ${buildCacheImage}")
				bat (script: "docker push ${buildCacheImage}")
				
				bat 'docker run -v %CD%:C:\\Build\\ --isolation=hyperv netsdkbuild c:\\build\\scripts\\build.bat' 
			}
		}
		gitlabCommitStatus("prepare test env") {
			stage('prepare test env') {		
				bat 'mkdir testResults'
				bat 'mkdir Settings'
				def apiUrl = params.apiUrl
				withCredentials([usernamePassword(credentialsId: '6839cbe8-39fa-40c0-86ce-90706f0bae5d', passwordVariable: 'AppKey', usernameVariable: 'AppSid')]) {
					bat "echo {\"AppSid\":\"%AppSid%\",\"AppKey\":\"%AppKey%\", \"BaseUrl\":\"%apiUrl%\" } > Settings\\servercreds.json"
				}
			}
		}
		gitlabCommitStatus("net tests") {
			stage('net tests') {	
				try {
					bat 'docker run -v %CD%:C:\\Build\\ --isolation=hyperv netsdkbuild c:\\build\\scripts\\net-test.bat Tests'
				} finally {
					junit '**\\testResults\\Tests-results-net452.xml'
				}
			}
		}
		gitlabCommitStatus("core tests") {
			stage('core tests') {					
				try {
					bat 'docker run -v %CD%:C:\\Build\\ --isolation=hyperv netsdkbuild c:\\build\\scripts\\core-test.bat Tests'
				} finally {
					junit '**\\testResults\\Tests-results-netcoreapp2.1.xml'
				}
			}
		}
		gitlabCommitStatus("bdd net tests") {
			stage('bdd net tests') {
				try {
					bat 'docker run -v %CD%:C:\\Build\\ --isolation=hyperv netsdkbuild c:\\build\\scripts\\net-test.bat BddTests'
				} finally {
					junit '**\\testResults\\BddTests-results-net452.xml'
				}
			}
		}
		gitlabCommitStatus("bdd core tests") {
			stage('bdd core tests') {
				try {
					bat 'docker run -v %CD%:C:\\Build\\ --isolation=hyperv netsdkbuild c:\\build\\scripts\\core-test.bat BddTests'
				} finally {
					junit '**\\testResults\\BddTests-results-netcoreapp2.1.xml'
				}
			}
		}
	} finally {
		bat 'docker system prune -f'
		deleteDir()
	}
}