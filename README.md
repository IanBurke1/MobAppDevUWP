# A Universal Windows Platform Application
#### *Mobile Applications Development Module - Lecturer: Damien Costello - 4th Year Software Development*
For my project in Mobile Applications Development, I am required to create a [Windows 10 UWP Application](https://docs.microsoft.com/en-us/windows/uwp/get-started/universal-application-platform-guide) in [Visual Studio](https://www.visualstudio.com/).  The application should incorporate the following elements:
- A responsive UI across the Windows 10 devices. There are some available for testing and this includes the IoT core, mobile devices, tablet and PC. This includes Visual State Management and using available SDKs for individual device types.
- A UI that has been well designed and is fit for purpose.  User Experience should be carefully considered while developing the application. The User Experience should be consistent across devices.
- Mobile services for data storage and retrieval. The cloud service does not have to be written in C# to be able to interact with a UWP. The preferred cloud to use is [Azure](https://azure.microsoft.com/en-gb/).
- Use of the MVVM design pattern in the development approach.

## Windows Store Link
**_Link to app on Windows Store: [Goal Setter]()_**

## Download Project
1. Click [here](https://github.com/ianburkeixiv/MobAppDevUWP/archive/master.zip) to download the zip of the project.
2. Extract the project into a directory.
3. Launch [Visual Studio](https://www.visualstudio.com/vs/whatsnew/) and open the MobDevUWP.sln
4. Build solution and run on local machine.

## Application
I have created a simple goal setting app where users can add their goals which is stored into a cloud database hosted by Azure. Users will see a list of their goals on the next pivot with delete and refresh functions. I also added a toast notification to let users know their goal is saved once they hit the save button. 

![](https://user-images.githubusercontent.com/22341150/33758882-2303e0d6-dbf8-11e7-988c-3416e6ce5375.PNG)

![](https://user-images.githubusercontent.com/22341150/33758890-27c54286-dbf8-11e7-8946-0a172f715c2f.PNG)

## Architecture

### Microsoft Visual Studio
[Visual Studio](https://www.visualstudio.com/) is an integrated development environment (IDE) from Microsoft. It is used to develop computer programs for Microsoft Windows, as well as web sites, web apps, web services and mobile apps. 

For this project, I have used Microsoft [Visual Studio 2017](https://www.visualstudio.com/vs/whatsnew/).

### C# and XAML
[C#](https://docs.microsoft.com/en-us/dotnet/csharp/) (pronounced C Sharp) is a hybrid of C and C++, it is a Microsoft programming language. C# is an object-oriented programming language used with XAML-based Web services on the .NET platform and designed for improving productivity in the development of Web Applications.

[XAML](https://msdn.microsoft.com/en-us/library/cc295302.aspx?f=255&MSPPError=-2147217396) (Extensible Application Markup Language) is an XML-based markup language developed by Microsoft. It it tpically used to create an application's user interface. It's basically behind the visual presentation of an application just like HTML is the language behind the visual presentation of a Web Page.

Both [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) and [XAML](https://msdn.microsoft.com/en-us/library/cc295302.aspx?f=255&MSPPError=-2147217396) interact with each other to create a Web application. Both are binding.

### Azure
[Microsoft Azure](https://azure.microsoft.com/en-us/overview/what-is-azure/) is a cloud computing service created by Microsoft for building, testing, deploying, and managing applications and services through a global network of Microsoft-managed data centers. It provides software as a service (SaaS), platform as a service and infrastructure as a service and supports many different programming languages, tools and frameworks, including both Microsoft-specific and third-party software and systems.