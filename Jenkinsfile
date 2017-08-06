
import groovy.json.JsonSlurper

node {
        
    
    
    stage('Build')
    {
        bat("\"C:\\Program Files (x86)\\MSBuild\\14.0\\Bin\\msbuild.exe\" \"C:\\Users\\lrogers\\Desktop\\git\\FinalPresentationRepo\\SimpleDemoProject\\SimpleDemoProject.sln\"")
    }
    
    stage('Test')
    {
        bat("del MSTestResults.trx")
        
        bat("\"C:\\Users\\lrogers\\Desktop\\tools\\OpenCover.4.6.519\\tools\\OpenCover.Console.exe\" -register -target:\"C:\\Program Files (x86)\\Microsoft Visual Studio 14.0\\Common7\\IDE\\mstest.exe\" -targetargs:\"/noisolation /resultsfile:MSTestResults.trx /testcontainer:\"C:\\Users\\lrogers\\Desktop\\git\\FinalPresentationRepo\\SimpleDemoProject\\SimpleDemoProject.Tests\\bin\\Debug\\SimpleDemoProject.Tests.dll\" /nologo\" -filter:+ -mergebyhash -output:Coverage.xml")
        
        bat("\"C:\\Users\\lrogers\\Desktop\\tools\\OpenCoverToCoberturaConverter.0.2.6.0\\tools\\OpenCoverToCoberturaConverter.exe\" -input:Coverage.xml -output:Cobertura.xml -sources:%WORKSPACE%")

         bat("\"C:\\Users\\lrogers\\Desktop\\tools\\ReportGenerator.2.5.8\\tools\\ReportGenerator.exe\" -reports:Coverage.xml -targetDir:CodeCoverageHTML")
                        publishHTML([
                                        allowMissing: false,
                                        alwaysLinkToLastBuild: false,
                                        keepAll: false,
                                        reportDir: 'CodeCoverageHTML',
                                        reportFiles: "index.htm",
                                        reportName: 'Test Results'])
        
    }

    //this is where the parameters for partial success based on test results and code coverage can be configured
    //A build can be marked as unstable (partially successful) if less than a certain amount fail, or a certain amount of new tests fail
    //A build can be marked as failed if more than a certain amount fail, or a certain amount of new tests fail

     step([$class: 'XUnitBuilder', testTimeMargin: '3000', thresholdMode: 1,
         thresholds: [
            [$class: 'FailedThreshold', failureNewThreshold: '', failureThreshold: '2', unstableNewThreshold: '', unstableThreshold: '1'],
            [$class: 'SkippedThreshold', failureNewThreshold: '', failureThreshold: '', unstableNewThreshold: '', unstableThreshold: '']],
         tools: [
            [$class: 'MSTestJunitHudsonTestType', deleteOutputFiles: false, failIfNotNew: false, pattern: 'MSTestResults.trx', skipNoTestFiles: true, stopProcessingIfError: true]]
        ])  

    //can't fail a build yet, targets arent exposed for pipeline use

    step([$class: 'CoberturaPublisher', 
        autoUpdateHealth: false, 
        autoUpdateStability: false, 
        coberturaReportFile: '**/Cobertura.xml', 
        failUnhealthy: true, 
        failUnstable: true, 
        maxNumberOfBuilds: 0, 
        onlyStable: false, 
        sourceEncoding: 'ASCII', 
        zoomCoverageChart: false
    ])

       
  
}
//adding a small change