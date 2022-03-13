# QA-_Fundamentals
QA _Fundamentals


Exercise: Testing Introduction
Problems for exercises and homework for the "QA Fundamentals" course @ Software University.

https://www.istqb.org/downloads/category/2-foundation-level-documents.html

1.	Find the Errors
You are given a picture of the homepage of Google, opened with a Google Chrome browser. Examine the picture and list the errors you can detect at a first glance. Then, you can open google.com for comparison and list the rest of the errors you have found after seeing it.
1-Gmail on the right is not on one line with :
2: чуестваме се късметлия и google търсене не са центрирани, 
3.The footer of the site is not well done the tab buttons;
4.there is not an internalization of the WebPage with another languages ;
5.there is not a butteon create an account, sign up,  only has sign in, 
6.Button  Google Търсене -> трябва да бъде Google Search, 
7.Няма възможност потребителят да сменя езиковата версия на страницата !

 
Fill in the table below the number of defects you have found.
DEFECTS:	
Look at the legend to judge your results:
Defects Found	
0 – 2	Poor
2 – 4	Average
5 – 7	Good
8 – 10 defects	Excellent
2.	Suggest Improvements
The extension of a Software Testing job is to provide suggestions for quality improvements. Take a look at this sign-in form. Think of how user experience can be improved for the following sign-in page:
 

Hello, 
Please enter  your email:  …
Please enter your Pass: …
Have You forgotten yor Pass : Please write an email form …(Reset password)
If I am new user : please crate an acount, 
If not -> sign in :…

////


3.	Think Testing
Here are a couple of cases. Think of all the different and appropriate solutions to them.
•	A woman fired a shot at another woman with her gun, but the other woman did not die. Why? List the possible reasons.

1.The firing woman was using only signal bullets(not real bullets)
2.The Firing woman did not intencially fired aside not to wound the other person.
3.The FireGun was defect.
4.the other woman was wearing a protective clothes.
5.The other woman escaped the bullets, 
6.The other woman was shot but into the leg and is alive.

•	How would you test a 5 kg capacity grocery-shopping paper bag?

1.I will put the bag onto a balancing scale and put exactly 5 kgs weight.
2.I will put first 5kgs  products into the scale basket then I will poor thees products from the basket into the paper Bag.
3.I will take another 5kgs paper bag that I have masured before and I am sure that it holds 5 kgs, 
and will compareits size with my new 5kgs Paper bag.



•	It is time to teach your child to brush its teeth alone. It needs clear step-by-step instruction, so list the steps and be as detailed as you can.

1.	Take the tooth brush, 
2.	Take your tooth-paste, 
3.	Open the cap of the tooth-paste, 
4.	Squeeze a litte from the tooth-paste over the tooth brush, not going out of the tooth –brush.
5.	Close the tooth-paste tube with the cap and put it back to its place.
6.	Open your mouth.
7.	Start washing your teeth about 3 Mins.
8.	Start the water
9.	Rinse your mouth with water
10.	Rinse the tooth-brush with water.
11.	Stop the water.
12.	Put the tooth brush onto its original place
13.	Free to go



4.	Test Psychology
It is an exercise from the ISQB textbook "Fundamentals of Software Testing ISTQB Certification".
Read the email below, and see what clues you find to help you identify problems in the scenario described. Categorize the clues/problems as:
• Possible people, psychology, and attitude problems;
• Other problems e.g., possible test management and role problems, possible product problems.

1.	Who is the tester, when is done, what he is doing exactly, on what environment, 
2.	What is he testing, what system exactly for what ???at what environment, test, devs
3.	Describe exactly the steps of test you are doing, pictures if needed, 
4.	User must be included to production environment, not to test environment.
5.	5.No properly showin the correct markets and the correct languages .
6.	Who is the manager, who is the another  employee, what ecactly they did, descrioption of steps to produce the bugs.




Hi there!
Well, I nearly caused a panic today because I thought I had found a mega showstopper on the trading system we are testing. The test manager and others got involved examining databases first on the server and then on the gateway that feeds the clients, checking update logs from processes that ran overnight as well as checking data passed to the client. Eventually, I found the problem. I had misclicked on a .bat file when running up a client and had run up the wrong client environment. By that time, the test manager was ready to say a few short words in my ear, particularly as the development people had started to get involved and they had zero tolerance for mistakes made by testers. The only saving grace was that I found the mistake and not one of the developers.
It was, objectively, an interesting mistake. When you log into the server test environments, the panels always show the environment to which you are connected. In our case, we have two test environments called Systest14 and Systest15, and my tests were set up in Systest15. To run up the clients, we have to run .bat files for either a 14 or 15 client. I had started two clients, that is two exchange participants so that I could do some trading between them.
It appears I started the first client OK in environment 15, but when I started the second, I accidentally moved the mouse a fraction, so it ran the 14 .bat file that is next to it in the Explorer file list. To make matters worse, the client screens do not show the environment to which you are attached.
At first, I felt a bit stupid, having caused much hectic and wasted activity. On reflection, I thought that if I, as a reasonably competent person, can make a mistake like this, something is wrong. On the server-side, when I log on to a test environment, I have to enter the environment name, and it's shown on all the panels. On the client-side, I run a client test environment by selecting a .bat file from a list of many and have to ensure I click on the right file. There is neither a display nor the ability to determine the client environment in which I am working.
So I will log this as a high priority, or even showstopper, error - the client does not show the environment. In real-life terms, it means a real user could be connected to the production system and think he is connected to a test system and screw up trading. I know this happened once on the equities trading system when a trader entered a load of test transactions into the production system by mistake and caused mayhem.
As an addendum to this story, a couple of days later, one of the testers found what appeared to be another mega showstopper. He and the test manager spent three hours crawling all over the system before discovering the 'error'. A new filter had been added to the client software to filter transactions displayed in panels by geographical market. Unknown to them, it was set to a default of the German market, whereas they thought they were in the UK market. Consequently, at first sight, it appeared there were fundamental problems with the network transaction bus and the message-broadcasting systems. Apart from the issue that they should have been informed of this change, it raised a similar problem to the one I had experienced -the client system does not display the market in which you are trading.
Well - I'm off for another happy day at the office! All the best!

Another :
When You come back, leave contacts,,,

///
 

QA->  to detect difference between existing fetures and the made feature -> requirements specification, test to find bugs, and to guaranty to some extent, that the quality of the software, that We to evaluate the Quality of the SoftWare. Exercizing the SoftWare. QA alse analyses the  SoftWare.Exe\rcizing the diffs between made and the specifications. If it works fast, secure, and has the usability. We estimate the quality of the tested Software !
Devs are Fixing the problems, bugs. Testing reduces risk of software bugs .
Busunesss Requirements are made by  business Analist to make Busunesss Requirements to Specifications
Testring Process :
-TestPlanning and testAnalyzing; -What will be tested which feature, module, Who, how many people, how much time, the Environment .
-TestDesigne and Execution -> Write test cases(1, 5, 50, 250 test cases) the manual test cases, 
we ecxecute them manually or automatically(then we sit and make manual  turns them into automation testing.)
--TestReporting and TestEvalutation.

StakeHolders –all key people involved on a given project, ProductManager, ProductOwners, DevManagers, SEOs, 

Main Aims of testing;
-prevention of defects.(bug prevention mind, bug detection mind), 
(-verification of the requirements-specifiactions ->  existring PringButton- yes exists –then verified
validation > if the button works correctly -> then it is validated !)
--lower/reduce the risk of unquality software
--to provide information of the stakeholders, 
--to check if the software answers to legal, contractual regulatory requirement.
Cockies is regulatory requirement.

Testing->(We find defects, failure- I push the LogIn btn and cant loginto, this is a bug, We have tested , we found failure, and we log it into)   
Debugging->Developers take the found bug, start to examin the software  analyse of the software, 
step by step to execute the code, this is called debugging(DebuggerInstrument).  Done to  Find the exact block into the code,  that causes the bug , and to fix it.
The debugging is made by the developer to find the defect into the block of the code, the code is executed step by step to reach the problem block of code !
QA profession uses a resource that is called human mistakes .
Why we have adefects-> because humans make mistakes, 
Reasons for software mistakes:
--Poor training, bad skills, lack of good knowledge--
---Time pressure, 
---Code Complexity (the project complexity);
--complexity of infrastructure can be our Laptop, or virtual machine, 
--changing technologies, 
--organisational communicational factors.
-- unclearly defined requirements (not good defined requirements-specifiacations .)
--environmental requirements -?  Low degrees, high degrees of working the Hardware and the Software.
Magnetism….
Feature is given functionality. –Difference ! 
One functionality is User to register into the WebSire, another is user to LogIn the WebSite.
Production Environment== Live Environment, 
QA Environment is test Environment=Staging Environment ;
Dev environement = development Environement;

Load Balancer -> is a computer ; is an intermediate machine server, balances the page load to the most not unloaded server. Distributes the page load to the WebServers./ Load balancer must be well set, Distributes the page load balance to the web Server, that why the environemtn is imoptoratna the cvonfigurations of the environemtn.

Bad Test  data-> not enough data,  filter with 20 yesa, our one user is 25 years, we don’t have user on 5, -1 y
Invalid expected results. Must be précised.After registration the user we must receive an activation link, but we don’t receive ,
Tester mistakes too , 

Any incident is logged intot the sompany system.
Soft Ware Testing, reduces the bugs, improves the quality, saves costs , saves lives !
2:31 Min ;

Риск Амнализ и  Приоритизация !!
Кога е най-евтин проблемът -> когато открием проблемът на ниво спецификация ;

Най-скъпо е отстраняването на проблемът в Продъкшън.

Agile : https://www.youtube.com/watch?v=Z9QbYZh1YXY

https://www.scrumalliance.org/about-scrum/overview
https://www.scrumguides.org/scrum-guide.html
https://www.atlassi... 
Вижте повече

 



