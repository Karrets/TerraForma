## This README is mostly just me planning what the game will be like, so it will be of little use to most!

# Feel free to read it anyway :)

Use these tilesets, along with some hue shifting to make a nice little preview world!
https://opengameart.org/content/outdoor-tiles-again
https://opengameart.org/content/outdoor-32x32-tileset
https://opengameart.org/content/the-field-of-the-floating-islands

Those 3 should have enough variation total to make something nice!

I would like to use a simple wiggle shader on the trees + other plants and bushes to make them feel a little more lively.

The higher the pixel the more the texture should be shifted I think? This will need a lot of tweaking to look good.


---
What are we doing?

IDEA!
Game about terraforming a planet. Do so as quickly as possible for a high score. Various natural disasters make it more and more difficult.
As the planet gets more and more habitable, people begin polluting the planet and making your job more and more difficult.
(Is this kind of post game content? Once you win you can continue. Or maybe the primary objective is to stay habitable for as long as possible.)

Game
Start with planet like mars and get to something like earth. From there, keep it habitable for as long as possible.

As the planet gets to be more and more habitable, more people show up?

Natural Disasters inhibit progress, asteroids solar flares and similar. When an event occurs, what if we had a pop-up / toast in the corner that had an info button.
Clicking the button pauses the game and allows you to read a blurb about what the event is. I.E. add some edutainment aspect. Not required though.

INFO ON HOW TO TERRAFORM:
https://en.wikipedia.org/wiki/Terraforming_of_Mars

PLAYED SPORE?: I'm stealing their terraforming gui. It is a simplification and will be expanded on though... Here's what theres looks like:
https://static.wikia.nocookie.net/spore/images/0/01/T0_terrascore.jpg

```
Basic Gameplay loop.
Terraform! (Primary Loop)
|
|- Improve Atmosphere
|  |-Add components need for life, (TODO: see what humans need...)
|  |-Remove noxious gasses. If planet has too dense of an atmosphere to start, reduce that too! (TODO: Livable conditions?)
|  |
|  \_Repeat^^^
|
|- Improve Tempurature
|  |-Related to atmosphere. Add greenhouse gasses to increase temp. Not too much or things will spiral.
|  |-Reduce green house gasses by adding trees! New tech like carbon capture etc.
|  |
|  \_Repeat^^^
|
|- Sustain
|  |-Prevent humans from messing things up! The more habitable the planet, the more people, and therefore the more emissions / greenhouse gas being created.
|  |-Natural Disasters and Space Phenomena need to be protected against. Needs research.
|  \_Repeat^^^
|
|- Break Loop (End game self? Unsure of end condition, maybe time limit? 45 minutes is a comfortable time I think. Maybe aim for 30...
|  |-Calculate score based on habitability.
|  \_No true end to game, get as far as you can as quickly as possible.
|
\_Repeat^^^
```

Components
How to limit the players actions in a fun way?
Funding. The player gets a paycheck from NASA or something to make a planet habitable.
As you get it more habitable, funding slows down maybe? Grants could be a thing to make bonus money for completing tasks or reaching milestones.
	Research classifications of habitability as checkpoints?

Keep game short enough that a save feature is not needed.
Game should be done in an hour, tops.

Ideally we don't have direct waiting periods. The effects of a players actions should be snappy so that the player doesn't feel like the games pacing is too slow.
At the same time make things feel like they aren't going to fast as well.
