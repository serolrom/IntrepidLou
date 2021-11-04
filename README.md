# IntrepidLou
 A romantic and intimate aviation adventure.  

**Intrepid Lou** is a video game currently in the first steps of development.  

You are an intrepid pilot who assembled an intrepid plane in a distant island, in the golden age of aviation. Except that in this remote place aviation is a rare thing. That's why your job is so valuable for the residents, and you'll never fall short of tasks to help the locals. Be a courier, perform search (and even rescue) missions, take fellows to a scenic flight, anything that brings enough money to "keep up" with your activity.  

For the most part, you will be supported by everyone. You'll most likely not find enemies. *Human* enemies, that is. Your real enemies will be the winds, the weather, your own navigation skills, your fuel economy and your ability to keep your plane healthy.

**Twitter:** https://twitter.com/IntrepidLou  
**Discord:** -not yet public, but it will come-

Dev Log
-------  
**2021-11-01**  
Gained consistency on boarding/deboarding the plane. But as usual, a couple of things broke down in the process. I can confidently call it a day.  

**2021-10-31**  
Today's 'productive' work went to searching resources. I got a couple of assets: the **Nature Starter Kit 2** from which I plan to get the kind of scenery I want, and also checked out some video about **Vegetation Spawner**, which will indeed come handy with such a big terrain.  
Speaking of which, a 10000 x 10000 grid is a pretty convenient size. The problem with this distance is how to fill it up with relevant content. Smaller than that and it won't make sense to travel by plane. That's why I'm generically looking at procedural generators. The idea is to procedurally create the terrain and vegetation. For villages I can maybe create them in a more manual way.  
A strategy might be like creating 1000 x 1000 squares, which are probably easier to explore manually, and then add neighbour regions, but that means I'll end up having to create 100 of these. We'll see. Then, the idea is to create the manual content and afterwards fill it up with procedural vegetation, which takes care automatically about not placing grass or tress on the layers where I don't allow it to, and also restrict it depending on terrain elevation. 

... aaaaand... later this day.... **my pilot can board the plane!!!** Well, maybe I have to do quite some refinement, but the boarding action is there. It's now a matter of positioning when getting in and out of the plane. Proper animations are also missing, something for the future. More immediate attention is needed to get the plane started and functional when the pilot is on board.  
Credits for the boarding functionality are for: https://www.youtube.com/watch?v=R4X8dsQeLQs


**2021-10-29**  
Not much progress in the last couple of days. Real life commitments kept me a bit away from the game.  
Also, this weekend I have to plan a real life flight route planned for Monday from my aerodrome to a nearby one, as part of my license journey. In order to be prepared for weather issues, I have to prepare two routes, one to an aerodrome to the north, and another one to the south, and will be simulating them in Flight Simulator. I hope this simulation time pays off!  
It's probably worth commenting at this point that I'm getting my ultra-light license. I've finally stopped wishing to fly for real, and got to it. 
Needless to say, my real flying helps me tweak the flight model for Intrepid Lou. I want this to be a game, not a simulator. Everyone should be able to pilot the game airplane. But at the same time, I want it to feel real. I firmly believe that, for a simple plane, you don't need a fully-fledged study-level flight simulator to transmit the sensation of the real thing. You can even transmit a significant part of the real skill it takes to fly for real, without needing to get real pilot training.  
  
Hmm... I ended up creating a github for source control AND logo with a background picture of mountains made by myself!. It's not impressive, but certainly good enough for my needs.  
Best thing again is how much I've learned today.

**2021-10-28**  
Human and Machine. They'll be doing great things together.  
![image](https://user-images.githubusercontent.com/10551472/139540675-f830ee1d-6311-4b94-a31d-6a26460e3b45.png)  

**2021-10-27**  
I'm pretty addicted to Unity in the last days, and I'm learning things at an elevated order of magnitude.
This means I'm watching tons of videos. Some of them show awesome creations done by people with so much talent that make me feel like 'what the heck are you doing, why are you even allowed to use Unity...'.  
It is at that point when I have to remind myself that, no matter how impressive is the work of others, making a game is a bit like writing a book. Regardless of skills, you do things in your own way. Everyone has their personal way of doing things that sets them appart of the rest. Otherwise there would only exist one writer, one cinema director, one architect. 
My game is mine. Despite I'm technically a galaxy far away from just about any actual developer, my game has not been created. I am creating it. And it can only be me, because only I know what I want it to be.  

Yeah, it really flies nice and smooth  
![image](https://user-images.githubusercontent.com/10551472/139540626-ef5ea30f-b87b-476e-8d53-f4152b81ef4a.png)
What's next? Errr.... everything!  

**2021-10-26**  
Today I starded over, as it is mostly usual since I started. But that's Ok. No, really, it's Ok.
Since I was starting from scratch, decided to apply what I did yesterday to this beauty. But I couldn't make it work. The model is facing 90º off, I had to play too many stunts with colliders, bodies and it finally just doesn't want to fly. I might come back to this plane at a later stage. By now I just need something that works, so back to the nice Nieuport.  
Now, the only reason I changed plane is not because the Nieuport was bad, but because the red one looks more in the lines of how I envision the game. But not even that one might make it to the finished game, should I ever get to see the game finished!  
![image](https://user-images.githubusercontent.com/10551472/139540580-46037b48-f766-431d-82e6-013b8eda4f6e.png)

**2021-10-25**  
In my last session I learned that when you hit 'Save' in Unity, what is happens is... I don't know what happens. I just know I don't find all the work I did for the day.
But that's nobody's fault but mine. What I keep is what I learned.  
I can re-apply the changes to the flight model. I was finally successful to the point I can move to the next topic. 
I still love you, Unity.  

**2021-10-24**  
The story so far: 
I only started the development of Intrepid Lou this week, and despite no actual progress can be seen, I've gone from 0 to 100 so soon that I don't want to let these initial steps get lost. 

Of course, "going from 0 to 100" has a different meaning depending on what we consider a 100. Considering I have never had real contact with any game engine, the fact that I have already set up a scene with a plane where I have placed a plane, and I have started coding its behavior, is such a big thing. I can now think of how do I want the game to look like, how I want the gameplay to be, what features I should be including, etc. I am not afraid of any of these things. I have taken the hardest step; the first one.  

Upgrading Unity to 2021 beta version; I want to check out visual scripting, and while there is Bolt as an add on for previous version, it will evolve to the native functionality in 2021 version, so there we go. This kind of means I'm mostly starting over from scratch again...  
