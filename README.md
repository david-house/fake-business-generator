# ESPOC

## Fake Company Name Generator

## Work in Progress
This is part of a proof of concept for a hybrid CQRS with SQL Server and Elasticsearch

### Note for Debugging in VS Code on Linux
I kept receiving errors loading .Net Core 3.0 preview projects in VS Code. Adding the environment variable ```MSBuildSDKsPath``` did *not* work for me. The solution that worked for me was to create the file ```~/.omnisharp/omnisharp.json``` with the following content:
```json
{
   "MSBuild": {
       "UseLegacySdkResolver": true
   }
}
```


