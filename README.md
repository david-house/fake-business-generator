## Fake Company Name Generator

## Work in Progress
Generates a tab-delimited text file of companies with a location. Each company has up to 2 additional alternate names, a business type, and two principal surnames.

Note: All data was taken from open sources. Place names came from USGS and US Surnames came from the Census Dept. ZIP codes came from open source data.

This is part of a proof of concept for a hybrid CQRS with SQL Server and Elasticsearch.

## To Use
In ```program.cs```:
1. Set ```n``` = number of company names to generate.
2. Set ```outputPath``` = output file path for text file of generated business names (tab-delimited).

Generating a file of 10M company names took ~53s on my i7-8700.

## Note for Debugging in VS Code on Linux
I kept receiving errors loading .Net Core 3.0 preview projects in VS Code. Adding the environment variable ```MSBuildSDKsPath``` did *not* work for me. The solution that worked for me was to create the file ```~/.omnisharp/omnisharp.json``` with the following content:
```json
{
   "MSBuild": {
       "UseLegacySdkResolver": true
   }
}
```


