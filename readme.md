## Game

Each game is a collection of hands. The number of hands in a game is specified in
config and could also be based on points.

An active game has one active hand at any time. Once the hand has 13 completed tricks, it
will complete. 

## Hand 

Each hand is a collection of tricks. In the standard game, there are 13 tricks in each hand.

When a new hand is created, cards are dealt to 4 players. These players are stored as
`HandPlayers` and their associated cards are stored as `HandPlayerCards`.

An active game has one active trick at any time. This active trick will remain active until
each of the 4 `HandPlayers` has created a `TrickElement`. The highest card out of the 4
played will be the winner of the trick. Once the trick is complete, a new trick is created
and this trick becomes the active trick. 

## Tricks

Each trick is a collection of trick elements. In the standard game there are 4 elements in
each trick representing the cards played by each of the 4 players. Players are stored at the
trick level to allow different players to pick up a game/hand/trick at any point.

## Controllers

### Game

- StartGame creates a Game, need at least one player
- FinishGame ends a game regardless of hands/status

### Hand

- StartHand takes a Game, 4 Players - creates first Hand, HandPlayers, HandPlayerCards and
waits on bids
- Bid creates a Bid for a given HandPlayer
- ResumeGame gets active Trick for a given Game/Hand, or creates new Hand if no active Trick
- FinishHand writes all trick detail to stats, sets EndStamp for Hand

### Trick

- StartTrick takes Hand and creates new Trick
- Play takes HandPlayerCard and writes new TrickElement
- FinishTrick sets EndStamp
- ResumeTrick ? 
