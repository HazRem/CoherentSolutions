using Task2_3;

Lecture lecture1 = new Lecture("Lecture on basics", "Introduction to Programming");
PracticalLesson practical1 = new PracticalLesson("First exercise", "www.example.com/task1", "www.example.com/solution1");
PracticalLesson practical2 = new PracticalLesson("Second exercise", "www.example.com/task2", "www.example.com/solution2");

Training training = new Training();
training.Add(lecture1);
training.Add(practical1);
training.Add(practical2);

Console.WriteLine(training);

Console.WriteLine("Is Practical Only: " + training.IsPractical());

Training clonedTraining = (Training)training.Clone();
Console.WriteLine("Cloned Training Contents:");
Console.WriteLine(clonedTraining);

lecture1.Topic = "Updated Topic";
Console.WriteLine("Original Training after modification:");
Console.WriteLine(training);
Console.WriteLine("Cloned Training after modification in original:");
Console.WriteLine(clonedTraining);