using Class09_EFCore.Data;

var context = new GameContext();
context.Seed();

context.Dispose();