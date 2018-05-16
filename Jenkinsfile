node('billing-qa') {
	try {
		stage('checkout'){
                checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '9d6c4dfa-042c-4ed1-81c7-9175179dddda', url: 'https://github.com/aspose-words-cloud/aspose-words-cloud-dotnet.git/']]])
                withCredentials([usernamePassword(credentialsId: '6839cbe8-39fa-40c0-86ce-90706f0bae5d', passwordVariable: 'AppKey', usernameVariable: 'AppSid')]) {
                    sh 'echo "{\\"AppSid\\": \\"$AppSid\\",\\"AppKey\\": \\"$AppKey\\", \\"BaseUrl\\": \\"https://auckland-words-cloud-staging.dynabic.com\\"}" > Settings/servercreds.json'
                }
            }
	
		stage('build'){
			bat '".nuget/NuGet.exe" restore Aspose.Words.Cloud.Sdk.sln'
			bat "\"${tool 'MSBuild 15.0'}\" Aspose.Words.Cloud.Sdk.sln"
        }
            
        stage('tests'){   
			try {
				bat "tools\\nunit\\nunit3-console.exe Aspose.Words.Cloud.Sdk.Tests\\bin\\Debug\\net45\\Aspose.Words.Cloud.Sdk.Tests.dll Aspose.Words.Cloud.Sdk.BddTests\\bin\\Debug\\net45\\Aspose.Words.Cloud.Sdk.BddTests.dll --workers=1"
			} finally {
				nunit testResultsPattern: 'TestResult.xml'
			}
        }
                    
	} finally {                       
         deleteDir()
    }		
}