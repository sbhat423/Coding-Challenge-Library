The solution - ToyRobotSimulator consists of two projects
1. ToyRobotSimulatorLibrary: ToyRobotSimulatorLibrary project contains all the functionality for the ToyRobotSimulator.
2. ToyRobotSimulatorProgram: ToyRobotSimulatorProgram make use of ToyRobotSimulatorLibrary and provide inputs.

To use the library ToyRobotSimulatorLibrary, the dll file has to be referenced by the program.
Step 1: Create an object of type Robot
Step 2: Create an object of type TableTop
Step 3: Create an object of type RobotController and pass the Robot object created in step 1 as a parameter 
		to the constructor.
Step 4: Call the ReadCommand method of RobotControllerObject and pass the set of commands as input parameter. 
		The result will be displayed on the Console.

ToyRobotSimulatorLibrary has been tested on 3 different commands inside files Test1.txt, Text2.txt and Text3.txt,
inside the folder ToyRobotSimulatorProgram/TestInputs/

Go through ToyRobotSimulatorProgram/program.cs for better understanding of utilising the library 
ToyRobotSimulatorLibrary and to supply it with input.