# Volume-Reducer
Made by Nameless in an afternoon

## Description
Automatically looks for process and depending on the configuration, will set the volume of said process

## How-to :
Download an installer [here](https://github.com/NamelessG0d/Volume-Reducer/releases/latest "Release page")
#### `Settings.json` format :
```json
{
  "Version": 1,
  "Processes": [
    {
      "TargetChild": "CptHost.exe",
      "TargetParent": "Zoom.exe",
      "TargetVolume": 1
    }
  ]
}
```

if `TargetChild` and `TargetParent` are the same, it will set the process directly 
