# Code Review for Programming Exercise 1 #

Reviewer Name: Aziz Nassar  
Reviewer Email: afnassar@ucdavis.edu

## Description ##

For this assignment, you will be giving feedback on the completeness of assignment three: Pikmini. In order to to do so, we will be giving you a rubric to give feedback on. For the feedback, please give positive criticism and suggestions on how to fix segments of code.

You only need to review code modified or created by the student you are reviewing. You do not have to review the code and project files that were given out by the instructor.

Abusive or hateful language or comments will not be tolerated and will result in a grade penalty or be considered a breach of the UC Davis Code of Academic Conduct.

If there are any questions at any point, please email the TA.

## Due Date and Submission Information ##
This code review is due on:
Wednesday, April 21st by 11:59 PM

A successful submission should consist of a copy of this markdown document template that is modified with your peer-review. The file name should be the same as it is in the template: PeerReview-Exercise1.md. You also need to include your name and email address in the Peer-reviewer Information section below. This review document should be placed into the base folder of the repo you are reviewing in the master branch. This branch should be on the origin of the repository you are reviewing.

If you are in the rare situation where there are two peer-reviewers on a single repository, append your UC Davis user name before the extension of your review file. An example: PeerReview-Exercise1-username.md. Both reviewers should submit their reviews in the master branch.  

## Solution Assessment ##

### Description ###

For assessing the solution, you will be choosing ONE choice from: unsatisfactory, satisfactory, good, great, or perfect. Place an x character inside of the square braces next to the appropriate label.

The following are the criteria by which you should assess your peer's solution of the exercise's stages.

#### Perfect #### 
    Can't find any flaws in relation to the prompt. Perfectly satisfied all stage objectives.

#### Great ####
    Minor flaws in one or two objectives. 

#### Good #####
    Major flaw and some minor flaws.

#### Satisfactory ####
    Couple of major flaws. Heading towards solution, however did not fully realize solution.

#### Unsatisfactory ####
    Partial work, not really converging to a solution. Pervasive Major flaws. Objective largely unmet.


### Stage 1 ###

- [x] Perfect
- [ ] Great
- [ ] Good
- [ ] Satisfactory
- [ ] Unsatisfactory

#### Justification ##### 
Captain is able to walk to the left and right appropriately.

### Stage 2 ###

- [x] Perfect
- [ ] Great
- [ ] Good
- [ ] Satisfactory
- [ ] Unsatisfactory

#### Justification ##### 
Motivate functions seem to be written properly, and the SlowWorker method is set to be the default on wakeup.

### Stage 3 ###

- [x] Perfect
- [ ] Great
- [ ] Good
- [ ] Satisfactory
- [ ] Unsatisfactory

#### Justifaction ##### 
Hitting the motivate command makes pirates produce objects at varying speeds as intended and then fall into the 'exhausted' state.

### Stage 4 ###

- [x] Perfect
- [ ] Great
- [ ] Good
- [ ] Satisfactory
- [ ] Unsatisfactory

#### Justifaction ##### 
Captain jumps when the Fire2 button is clicked, which is the intended added functionality. The addition of enemies and inventory mechanincs was awesome and the icing on the cake.

## Code Style ##

### Description ###
Check the scripts to see if the student code adheres to the dotnet style guide.

If there are sections that don't adhere to the style guide, please peramlink the line of code from Github and justify why the line of code has infractured the style guide.

It should look something like this:

* [description of infraction](https://github.com/dr-jam/ECS189L) - this is the justification.

Here is an example of the permalink drop down on Github.

![Permalink option](../images/permalink_example.png)

Here is another example as well.

* [I go to Github and look at the ICommand script in the ECS189L repo!](https://github.com/dr-jam/ECS189L/blob/1618376092e85ffd63d3af9d9dcc1f2078df2170/Projects/CommandPatternExample/Assets/Scripts/ICommand.cs#L5)

### Code Style Review ###

#### Style Guide Infractions: ####

This by no means a significant nor noticable thing, but some of the comments on the code, while descriptive and well-placed, don't follow the convention of being on their own lines for a few lines, 
and instead fall right after the code itself.  
https://github.com/ensemble-ai/exercise-1-command-pattern-KathyLiu20/blob/15d3fe96d932eb0a8d54f6d2472124d67dfddfa7/Captain/Assets/Scripts/NormalWorkerPirateCommand.cs#L55  

https://github.com/ensemble-ai/exercise-1-command-pattern-KathyLiu20/blob/15d3fe96d932eb0a8d54f6d2472124d67dfddfa7/Captain/Assets/Scripts/NormalWorkerPirateCommand.cs#L11  

  
#### Style Guide Exemplars: ####  

The code's layout follows the proper conventions, making it very easy to read, especially around nested if statements: Conditionals are between proper sets of parentheses, there is only one statement/declaration per line, 
and the indentation is proper and allows readers to follow the vertical and lateral progression of the code.  

https://github.com/ensemble-ai/exercise-1-command-pattern-KathyLiu20/blob/15d3fe96d932eb0a8d54f6d2472124d67dfddfa7/Captain/Assets/Scripts/PirateController.cs#L32




 
## Best Practices ##

### Description ###

If the student has followed best practices (Unity coding conventions from the StyleGuides document) then feel free to point at these segments of code as examplars. 

If the student has breached the best practices and has done something that should be noted, please add the infracture.

This should be similar to the Code Style justification.

* [description of infraction](https://github.com/dr-jam/ECS189L) - this is the justification.

### Best Practices Review ###

#### Best Practices Infractions: ####

The worker classes get a little bit long around the prefab creation part, which could be refactored into its own function for clarity and reuse.  
https://github.com/ensemble-ai/exercise-1-command-pattern-KathyLiu20/blob/15d3fe96d932eb0a8d54f6d2472124d67dfddfa7/Captain/Assets/Scripts/FastWorkerPirateCommand.cs#L49  
  



#### Best Practices Exemplars: ####

The code is extremely well-commented, variables are explained next to their declarations, logic blocks are explained before, next to, and after their lines of code, which
makes the entire script library easy to follow.   

Example of well documented variables.  
https://github.com/ensemble-ai/exercise-1-command-pattern-KathyLiu20/blob/15d3fe96d932eb0a8d54f6d2472124d67dfddfa7/Captain/Assets/Scripts/FastWorkerPirateCommand.cs#L11  
  
Example of function purpose explanation.  
https://github.com/ensemble-ai/exercise-1-command-pattern-KathyLiu20/blob/15d3fe96d932eb0a8d54f6d2472124d67dfddfa7/Captain/Assets/Scripts/SlowWorkerPirateCommand.cs#L36  

Example of code logic around relavent lines that need explanation.  
https://github.com/ensemble-ai/exercise-1-command-pattern-KathyLiu20/blob/15d3fe96d932eb0a8d54f6d2472124d67dfddfa7/Captain/Assets/Scripts/NormalWorkerPirateCommand.cs#L53  
