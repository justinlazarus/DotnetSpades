# Spades

## Game

Each game is a collection of hands. The number of hands in a game is specified in
config and could also be based on points.

## Hand 

Each hand is a collection of tricks. In the standard game, there are 13 tricks in each hand.
An active game has one active hand at any time.

## Tricks

Each trick is a collection of trick elements. In the standard game there are 4 elements in
each trick representing the cards played by each of the 4 players. Players are stored at the
trick level to allow different players to pick up a game/hand/trick at any point.

