# Songs-QaAssignment

Overview
In this test you’ll write code to practice using C# and the concepts which you’ve learned
during the course. There are no detailed step by step instructions but you’ll find sufficient
instructions for each task.
There is no pass/fail mark for this assessment; however, your work will be uploaded to
Canvas as a record of the progress you have made on the course.
You will have 90 minutes to complete this task.
a) Create a new project
1. Create a new Console application. Call it Songs.
b) Create a new Class
2. Add a new class to your project. Call it Song.
Ensure that you make this a ‘public’ class so that it is potentially accessible from outside
this project.
This class should have the following encapsulated fields. You should choose
appropriate types for each field:
name
artist
copiesSold
3. Add a constructor to the Song class which allows clients to specify the name, artist and
copies sold when instantiating an object of this type.
4. Add a GetArtist() method that returns just the artist’s name.
5. Add a GetDetails() method that returns a string in the format
“Name: &lt;name&gt; Artist: &lt;artist&gt; Copies Sold: &lt;copiesSold&gt;”
6. Add another method to the Song class. Call it GetCertification(). It should have a
return type of string, and the string it returns should be based on the copies sold,
according to the following table:
&lt;200,000 null
&lt;400,000 “Silver”
&lt;600,000 “Gold”
&gt;=600,000 “Platinum”

Fundamentals course test

Page 2

c) Test your class
7. Create a unit test project and class for testing the Song class.
Write some unit tests to check that the GetCertification() method returns the correct
value for a selection of values of copiesSold. Each test should be just a few simple lines
of code.
You must not get bogged down in this section, it is imperative that you move on from
this point within a few minutes as there is much important work to be done in the
following sections.
If you are having difficulties, then attempt to write just one test, move on and return to
this section later.
d) Allow the user to enter song details for a single song
8. In the Program class, add a method with the following signature:
static Song InputSongDetails()
The method should ask the user for the name of a song, the name of the artist, and the
number of copies sold. It should apply whatever type conversions and validations are
necessary, and then create a Song object. Finally, it should return the new Song object.
You may find it easier to write some additional methods to help with the validation.
It’s recommended that you (temporarily) add a few lines of code to the Main() method to
test that the InputSongDetails() method works correctly. Once you are happy, remove
your test code.
e) Make an array of songs
9. In the Main() method, create a variable of type “Array of Songs”, and initialise it to a new
array that is capable of containing 5 references (to songs of course)
10. After declaring and creating the array, write a loop that runs enough times to fill the
array. Inside the loop, call the InputSongDetails() method, and store the return value
from this method in the array.
f) Query the array of songs
11. In the Main() method, after the loop that you created in the previous step, prompt the
user to “Enter an artist name, or just press Return for all artists”.
12. Use a loop to go through each item of the array in turn. For each item:
a. If the artist matches the artist that the user entered, or if the user pressed Return
without entering an artist, then display details of the song.
b. The details displayed should include the certification awarded (if any).