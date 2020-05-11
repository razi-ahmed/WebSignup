# WebSignup

This Solution has 2 projects. 
- WebSignup
- WebSignupAPI

WebSignup uses ASP.NET MVC Project template. Bootstrap and jquery are used in the UI.
  - on submit of the registration data, the UI makes ajax calls to the webapi.
  - on success moves the registration to the next registration step

WebSignupAPI is a.Net Core 3.1 web api. The design is based on SOLID priniciples.
  IEmailService Interface is used for any EmailService, either Simple Smtp or AWS SES.
  IRegisterationService and IRegistrationRepository designed to be unit test using any Mock libraries.
  
Alternately, the WebsignupAPI can be converted into Lambdas and deployed to any cloud service, for enhanced logging and integrated email
and queuing features.

Sample SQL Stored Procedure
CREATE PROCEDURE dbo.spINSERT_dbo_UserProfile @Fullname varchar(25), @PhoneNumber varchar(15), @EmailAddress varchar(25),
 @Address varchar(50)
SET NOCOUNT ON
INSERT INTO [dbo].[UserProfile]
           ([FullName]
           ,[Address]
           ,[PhoneNumber]
           ,[EmailAddress]
           ,[CreateDate])
     VALUES
           (@FullName
           ,@Address
           ,@PhoneNumber
           ,@EmailAddress
           ,getdate())
GO
