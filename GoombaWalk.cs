class GoombaWalk{
    private Star star;
    private Goomba goomba;
    private Ground ground;
    public GoombaWalk(Star star, GoombaAdv goomba, Ground ground){
        this.star = star;
        this.goomba = goomba;
        this.ground = ground;
    } 
    private void DrawFrame(){
        star.DrawSprite();
        goomba.DrawSprite();
        ground.DrawSprite();
    }
    public void StartAnimation(){
        int frameNumb = 20;
        int sleepTime= 200;
        for(int i = 0; i < frameNumb; i++){
            Console.Clear();
            DrawFrame();
            goomba.UpdatePos();
            Thread.Sleep(sleepTime);
        }
        goomba.changeDir();
        goomba.UpdatePos();
        for(int i = 0; i < frameNumb; i++){
            Console.Clear();
            DrawFrame();
            goomba.UpdatePos();
            Thread.Sleep(sleepTime);
        }
    }

}