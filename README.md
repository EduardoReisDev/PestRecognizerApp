# PestRecognizerApp

Application developed in .NET MAUI (iOS and Android) using Azure CustomVision to recognize plants attacked by pests. 🌱 🐛 🔍 📱

 [![GitHub stars](https://img.shields.io/github/stars/EduardoReisDev/SpaceXhistory?style=flat-square)](https://github.com/naweed/MauiTubePlayer/stargazers) [![GitHub last-commit](https://img.shields.io/github/last-commit/EduardoReisDev/SpaceXhistory?style=flat-square)](https://github.com/jameslee214/maui-premierleague/commits)

#### How does Azure CustomVision work?

![image](https://user-images.githubusercontent.com/52722526/160287168-eed0cd3b-4da4-413b-a1d7-4d6361108fcd.png)

## Plugins e Framework
#### Plugins
- Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction
- The49.Maui.BottomSheet

#### Framework
- .NET MAUI with .NET 7

## Images used in training
#### Tag 'healthy'
![image](https://user-images.githubusercontent.com/52722526/160287190-db6a0352-a180-4e59-aa9e-395d7254e676.png)

#### Tag 'not-healthy'
![image](https://user-images.githubusercontent.com/52722526/160287199-c1d55d69-1870-4575-bd1a-e9acf7afcac3.png)

### Performace
<img width="500" alt="image" src="https://github.com/EduardoReisDev/PestRecognizerApp/assets/52722526/4dbb9901-9c9d-46a8-9be0-3f037836095b">

## Getting Started in .NET MAUI ##

* [Install .NET MAUI](https://dot.net/maui)
* [.NET MAUI Documentation](https://docs.microsoft.com/dotnet/maui)
* [.NET MAUI Samples](https://github.com/dotnet/maui-samples)
* [Development Guide](./.github/DEVELOPMENT.md)
 
 ![maui-01-overview](https://user-images.githubusercontent.com/52722526/202878978-aa019b8a-6811-4df8-9014-125ea64f6faf.png)
 
 ## Architecture
 
 .NET MAUI unifies Android, iOS, macOS, and Windows APIs into a single API that allows a write-once run-anywhere developer experience, while additionally providing deep access to every aspect of each native platform.
 
 .NET MAUI provides a single framework for building the UIs for mobile and desktop apps. The following diagram shows a high-level view of the architecture of a .NET MAUI app:
 
 ![2021-10-06-19-12-58](https://user-images.githubusercontent.com/52722526/202879168-0cdf7e84-8959-4234-b528-63956a459b26.png)
 
 In a .NET MAUI app, you write code that primarily interacts with the .NET MAUI API (1). .NET MAUI then directly consumes the native platform APIs (3). In addition, app code may directly exercise platform APIs (2), if required.
 
#### MVVM Pattern
  
The MVVM pattern helps to cleanly separate an application's business logic and presentation from its user interface (UI). Maintaining a clean separation between application logic and user interface helps resolve numerous development issues and makes an application easier to test, maintain, and evolve. It can also significantly improve code reuse opportunities and allow developers and UI designers to more easily collaborate in the development of their respective parts of an application.

![mvvm-pattern](https://user-images.githubusercontent.com/52722526/202914348-8cdaa5d1-9495-4eaa-978a-5da384c55085.png)

## Result

#### Video

https://github.com/EduardoReisDev/PestRecognizerApp/assets/52722526/bafddead-ad64-4212-8258-5aa35ac30ada

