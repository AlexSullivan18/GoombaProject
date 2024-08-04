class Goomba{
        protected int posX;
        private int speed;
        private string[] goombaSprite;
        private bool direction;

        public Goomba(int speed){
					posX = 0;
					this.speed = speed;
                    goombaSprite = new string[10];
                    direction = true;
                    SetSprite(); 
					}
    
        private void SetSprite(){
                    //for store star image to star Sprite
                    goombaSprite[0] = @"     ________  ";
                    goombaSprite[1] = @"    /        \ ";
                    goombaSprite[2] = @"   /  \    /  \ ";
                    goombaSprite[3] = @"  /   |    |   \ ";
                    goombaSprite[4] = @" /  -^------^-  \ ";
                    goombaSprite[5] = @"|________________| ";
                    goombaSprite[6] = @"      /    \ ";  
                    goombaSprite[7] = @" ____|      |____ ";
                    goombaSprite[8] = @"/____\ ==== /____\ ";
                    goombaSprite[9] = @"                     ";
                }
        public virtual void DrawSprite(){
                    //draw sprite at posX
                    string spaces = "";
                    for(int i=0; i<this.posX; i++){
                        spaces+=" ";
                    }
                    foreach(string eachline in goombaSprite){
                        Console.WriteLine(spaces + eachline);
                    }

                }
        public void changeDir(){
            if (direction) direction = false;
            else direction = true;
            //direction = direction?false:true;
        }

        public void UpdatePos(){
            if(direction)
                posX += speed;
            else    
                posX -= speed;
        }

}