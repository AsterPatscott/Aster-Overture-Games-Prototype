Howdy folks!

So, as stated in my email, I unfortunately only saw the email about this prototype on the morning of the 6th, two days before it was due.
I managed to get a day off work and decided to pull together as much as I could in that limited time.


Current features:
- Pressing play on the play button in the upper left box plays the sample track. The solution is shown in that same box.
- Drag measures from the spawners in the upper right box, they will slot into the empty measure slots in the DAW.
- If you input the correct pattern of measures and hit the "Submit answer" Button, text will tell you if you got it right or not.
- The application should scale okay with different aspect ratios and resolutions, but I wasn't able to test this as much as I'd like.


Currently known bugs:
- Once you take a measure from the box on the upper right, the duplicate it creates will change size. This is one of those bugs where everything was working fine last night, then in the morning, this was happening and I don't have time to chase down the cause before the deadline, though I did try to fix it.
- When dragging the measure, clicking on the squares doesn't count, you have to click on the pink parts. dragging still works though so I considered this low priority
- leaving a measure empty in the DAW counts as just a measure of empty beats.


Planned or unfinished features:
- Playing what is in the DAW is currently not functional, there is a play button but it doesn't currently do anything. There is a script in the "DAW Manager" That was supposed to handle this but I ran out of time. There's the bones of some plans there but I was planning on looking more into procedural audio/music generation techniques and how music production software is coded. 
- Scalability: As of right now, the system really only accounts for 4/4 measures where a sound is either played or not played. I would like to make something more easily scalable for sustained notes, different time signatures, or different note lengths.
- Lives system: There is currently no limit on the amount of incorrect guesses you can make.
- Main menu/level select menu: Because I had limited time these fell by the wayside.
- Win/Fail state: Because there is no main menu, game states aren't really implemented.
- More levels, songs and sounds: You currently have to manually input the correct answer to be checked against the player's input this could be made more scalable in the future depending on how that's handled.
