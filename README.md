# TSTuring-MVCWeb-Client
### Discussion: 

http://forum.thinkingsolutions.co/forums/forum/mvc-web-client/

### Description
This web client provides access to the Thinking Solutions Language Algorithm for:

 - conversation 
 - translation and 
 - understanding.

Each of those applications uses the server API to analyze and retrieve responses.

> The design of the system is to consolidate the language content and meanings centrally 
> for all languages. While languages continue to be built up, the APIs will continue unchanged
> to allow the user community to continue to operate.

### Version

1.0.0

### Notes
This is an early release, feel free to inspect or use as you like but no contributions are expected until the next server release.

### Technology

The web client uses Microsoft MVC technology to control access to the server. StructureMap provides
dependency injection for MVC.

### Installation

Once you retrieve the Visual Studio project, set the default project to TSTuring2015.MVCWeb(see below), then RUN.
> In Visual Studio Specify the startup project a as TSTuring2015.MVCWeb by:
> right click solution >> properties >> startup project >> select single startup project >> TSTuring2015.MVCWeb

Your default browser should open with the home screen. Provided your web access is available, the remote server
will supply responses to your requests in line with the server content availability.

### Tutorials

A number of videos demonstrate the functionality of the three applications. Developers who want to embed this into
code should use the working versions in this client code for sample of how to interact with the API.

Introduction to the translation revolution & why Google Translate is fighting a losing battle
https://www.youtube.com/watch?v=mPoE5R3q5n0

Introduction to conversation & why statistical systems are inadequate
https://www.youtube.com/watch?v=YQ2uJaeDy8s         

### Background

The ‘clients’ provide exposure to the new technology which enables human-like understanding of language – potentially any language.  Currently, it has enough language loaded in English and 8 others to show samples of how it works.  A developer can see the output of our system if they download the source code and trace it.  They can see the result of the system by looking at the output on the Thinking Solutions Demo site, and the YouTube videos on Thinking Solutions channel.
 
The system produces a set of elements (roles – actor, undergoer; nucleus – adjective, noun, verb, location; attributes – positive/negative, past/present/future, aux type, voice; logical structure; etc)  that have been made available with this new multi-lingual natural language understanding (NLU).
 
The details of the system follow the Role and Reference Grammar. How Logical Structures are created is covered in the textbooks and scientific papers, but the point of the system is to remove the need for the developer to become a scientist and instead use the output of the system. That being said, as with any programming, the developer needs to be familiar with the justification for the end-to-end process.
 
Of course as sentences become more complex, the amount of embedding in the system requires the developer to pay attention to the output.
 
The next planned development phase for language loading (on the server) will be:
 
- Focus on English
- Load vocabulary and patterns to cover scope for connected homes and connected cars
 
This is dependent on funding and/or a suitable project.  Your feedback and interest in language applications for this software is welcome.


### Todo's

- Add Developer Feedback Loop
 
- Add GitHub comments regarding Thinking Solutions server projects

License

----



MIT
