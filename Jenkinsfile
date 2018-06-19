parameters {
        string(name: 'branch', defaultValue: 'master', description: 'branch to test')		
		string(name: 'testServerUrl', defaultValue: 'https://auckland-words-cloud-staging.dynabic.com', description: 'server url')		
}

node('billing-qa') {
	try {
		stage('checkout'){
                checkout([$class: 'GitSCM', branches: [[name: '*/' + params.branch]], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '9d6c4dfa-042c-4ed1-81c7-9175179dddda', url: 'https://github.com/aspose-words-cloud/aspose-words-cloud-dotnet.git/']]])
                withCredentials([usernamePassword(credentialsId: '6839cbe8-39fa-40c0-86ce-90706f0bae5d', passwordVariable: 'AppKey', usernameVariable: 'AppSid')]) {
                    bat 'md Settings & echo {"AppSid": "%AppSid%","AppKey": "%AppKey%", "BaseUrl": "%testServerUrl%"} > Settings/servercreds.json'
                }
            }
	
		stage('build'){
			bat '".nuget/NuGet.exe" restore Aspose.Words.Cloud.Sdk.sln'
			bat ".\\tools\\specflow\\specflow.exe generateall  Aspose.Words.Cloud.Sdk.BddTests\\Aspose.Words.Cloud.Sdk.BddTests.csproj /force /verbose"
			bat "\"${tool 'MSBuild 15.0'}\" Aspose.Words.Cloud.Sdk.sln"
        }
            
        stage('tests'){   
			try {
				bat "tools\\nunit\\nunit3-console.exe Aspose.Words.Cloud.Sdk.Tests\\bin\\Debug\\net45\\Aspose.Words.Cloud.Sdk.Tests.dll --workers=1"
			} finally {
				nunit testResultsPattern: 'TestResult.xml'
			}
        }
        
        stage('bddtests'){   
			try {
				bat "tools\\nunit\\nunit3-console.exe /result:bddtestresult.xml Aspose.Words.Cloud.Sdk.BddTests\\bin\\Debug\\net45\\Aspose.Words.Cloud.Sdk.BddTests.dll --workers=1 "
			} finally {
				nunit testResultsPattern: 'bddtestresult.xml'
			}
        }
                    
	} finally {                       
         deleteDir()
    }		
}