# HelloWorld_Assessment
This solution has below projects.

1. HelloWorldConsole - Console application which calls the controller to write the message. 
2. HelloWorldApi - This API is created as a class library. It has a MessageController class which will create the Writer based on messagewriteraction 
    and call WriteMessage method.
3. HelloWorldWriter - This is created as a class library and uses factory pattern to create the MessageWriter based on the config value passed
    by client. 
4. HelloWorldApi.Tests - Test project for Api and Writer class library
