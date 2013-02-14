Here is the bad news: the new developer you hired has written some terrible, atrocious code. 
No one can understand what it does. 

The good news: at least there are unit tests to prove the code is working. 

You job is to refactor the code and make it readable, while keeping the code in working order (pass all tests). 

!!How To Start!!

  1.	Open the solution file. 

  2.	Run the tests to make sure everything is in working order.
        Note: you'll need to use an xUnit.net test runner. 
        R# users can get xunitcontrib-resharper from http://xunitcontrib.codeplex.com/
        Otherwise, download xUnit from http://xunit.codeplex.com/releases/view/77573.
        Once you've unblocked and extracted the files, run xunit.gui.exe.

  3.	Start refactoring! 
  
  
The primary goal is to refactor the code in Algorithm\Finder.cs – as it stands the code is incomprehensible. 

!!Tips!!

-	Start with simple rename refactors so you can better understand the abstractions you are working with. 
    Rename any class or any variable. 

-	Move on to extract methods and making the code more modular.

-	See if you can also eliminate switch statements and multiple exit points from methods. 

Anything is fair game  – create new classes, new methods, and rename tests. 
The only restriction is that the existing tests have to keep working. 
Lean on the tests and run them after every small change to make sure you are on the right path.

!!How to End!!

You can stop when you feel the code is good enough – something you can come back to in 6 months and understand. 