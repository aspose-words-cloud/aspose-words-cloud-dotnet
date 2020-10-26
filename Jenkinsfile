properties([
	gitLabConnection('gitlab'),
	[$class: 'ParametersDefinitionProperty', 
		parameterDefinitions: [
			[$class: 'StringParameterDefinition', name: 'branch', defaultValue: 'master', description: 'the branch to build'],
			[$class: 'StringParameterDefinition', name: 'apiUrl', defaultValue: 'https://api-qa.aspose.cloud', description: 'api url'],
            [$class: 'BooleanParameterDefinition', name: 'ignoreCiSkip', defaultValue: false, description: 'ignore CI Skip'],
		]
	]

])

def buildCacheImage = "git.auckland.dynabic.com:4567/words-cloud/api/net" 
def needToBuild = false

node('win2019') {
	try {
		gitlabCommitStatus("checkout") {
			stage('checkout'){
				checkout([$class: 'GitSCM', branches: [[name: params.branch]], doGenerateSubmoduleConfigurations: false, extensions: [[$class: 'LocalBranch', localBranch: "**"]], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '361885ba-9425-4230-950e-0af201d90547', url: 'https://git.auckland.dynabic.com/words-cloud/words-cloud-dotnet.git']]])
				
                bat 'git show -s HEAD > gitMessage'
                def commitMessage = readFile('gitMessage').trim()
                echo commitMessage
                needToBuild = params.ignoreCiSkip || !commitMessage.contains('[ci skip]')               
                bat 'git clean -fdx'
			}
		}
        
        if (needToBuild) {
            gitlabCommitStatus("build") {
                stage('build') {
                    withCredentials([usernamePassword(credentialsId: 'cc2e3c9b-b3da-4455-b702-227bcce18895', usernameVariable: 'dockerrigistry_login', passwordVariable: 'dockerregistry_password')]) {
					bat 'docker login -u "%dockerrigistry_login%" -p "%dockerregistry_password%" git.auckland.dynabic.com:4567'
				}
                    bat 'if exist testResults del testResults'
                    bat 'mkdir testResults'
                    bat 'if exist Settings del Settings'
                    bat 'mkdir Settings'
                    def apiUrl = params.apiUrl
                    withCredentials([usernamePassword(credentialsId: '6839cbe8-39fa-40c0-86ce-90706f0bae5d', passwordVariable: 'AppKey', usernameVariable: 'AppSid')]) {
                        bat "echo {\"AppSid\":\"%AppSid%\",\"AppKey\":\"%AppKey%\", \"BaseUrl\":\"%apiUrl%\" } > Settings\\servercreds.json"
                    }

                    bat (script: "docker pull ${buildCacheImage}")
                    bat (script: "docker build -m 4g -f scripts\\build.Dockerfile --isolation=hyperv -t netsdkbuild --cache-from=${buildCacheImage} -t ${buildCacheImage} .")		
                    bat (script: "docker build -f scripts\\build.Dockerfile -t netsdkbuild --cache-from=${buildCacheImage} -t ${buildCacheImage} .")
                    bat (script: "docker push ${buildCacheImage}")
                }
            }
           
        
            gitlabCommitStatus("net tests") {
                stage('net tests') {	
                    try {
                        bat 'docker run -v %CD%\\testResults:C:\\build\\testResults\\ --isolation=hyperv netsdkbuild c:\\build\\scripts\\net-test.bat Tests'
                    } finally {
                        junit '**\\testResults\\Tests-results-net462.xml'
                    }
                }
            }
            gitlabCommitStatus("core tests") {
                stage('core tests') {
                    try {
                        bat 'docker run -v %CD%\\testResults:C:\\build\\testResults --isolation=hyperv netsdkbuild c:\\build\\scripts\\core-test.bat Tests'
                    } finally {
                        junit '**\\testResults\\Tests-results-netcoreapp2.1.xml'
                    }
                }
            }
            gitlabCommitStatus("bdd net tests") {
                stage('bdd net tests') {
                    try {
                        bat 'docker run -v %CD%\\testResults:C:\\Build\\testResults --isolation=hyperv netsdkbuild c:\\build\\scripts\\net-test.bat BddTests'
                    } finally {
                        junit '**\\testResults\\BddTests-results-net462.xml'
                    }
                }
            }
            gitlabCommitStatus("bdd core tests") {
                stage('bdd core tests') {
                    try {
                        bat 'docker run -v %CD%\\testResults:C:\\Build\\testResults --isolation=hyperv netsdkbuild c:\\build\\scripts\\core-test.bat BddTests'
                    } finally {
                        junit '**\\testResults\\BddTests-results-netcoreapp2.1.xml'
                    }
                }
            }
        }
	} finally {
		bat 'docker system prune -f'
	}
}