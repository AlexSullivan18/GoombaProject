// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Star star = new Star(0);
//star.DrawSprite();
//Ground ground = new Ground(120);
//ground.DrawSprite();
//Goomba goomba = new Goomba();
//goomba.DrawSprite();
Star star = new Star(10);
Ground ground = new Ground(120);
Goomba goomba = new Goomba(4);
GoombaAdv gAdvance = new GoombaAdv(4);
GoombaWalk gWalk = new GoombaWalk(star, gAdvance, ground);
Console.Clear();
gWalk.StartAnimation();
