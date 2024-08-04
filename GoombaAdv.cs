class GoombaAdv : Goomba
{
    private int count = 0;
    private string[] goombaSpriteLeftFoot;
    private string[] goombaSpriteRightFoot;
    

    public GoombaAdv(int speed) : base(speed)
    {
        goombaSpriteLeftFoot = new string[10];
        goombaSpriteRightFoot = new string[10];
        SetSprite();

    }

    public override void DrawSprite()
    {          
        if(count%2==0){
            //draw sprite at posX
                    string spaces = "";
                    for(int i=0; i<this.posX; i++){
                        spaces+=" ";
                    }
                    foreach(string eachline in goombaSpriteLeftFoot){
                        Console.WriteLine(spaces + eachline);
                    }
        }
        else{
                    string spaces = "";
                    for(int i=0; i<this.posX; i++){
                        spaces+=" ";
                    }
                    foreach(string eachline in goombaSpriteRightFoot){
                        Console.WriteLine(spaces + eachline);
                    }
        }

        count = count+ 1;
    }

    private void SetSprite()
    {   
        goombaSpriteLeftFoot[0] = @"     ________  ";       
        goombaSpriteLeftFoot[1] = @"    /        \ "; 
        goombaSpriteLeftFoot[2] = @"   /  \    /  \ ";
        goombaSpriteLeftFoot[3] = @"  /   |    |   \ ";
        goombaSpriteLeftFoot[4] = @" /  -^------^-  \ ";
        goombaSpriteLeftFoot[5] = @"|________________| ";
        goombaSpriteLeftFoot[6] = @" ____ /    \ ";  
        goombaSpriteLeftFoot[7] = @"/____\      |____ ";
        goombaSpriteLeftFoot[8] = @"       ==== /____\ ";
        goombaSpriteLeftFoot[9] = @"                     ";

        goombaSpriteRightFoot[0] = @"     ________  ";
        goombaSpriteRightFoot[1] = @"    /        \ ";
        goombaSpriteRightFoot[2] = @"   /  \    /  \ ";
        goombaSpriteRightFoot[3] = @"  /   |    |   \ ";
        goombaSpriteRightFoot[4] = @" /  -^------^-  \ ";
        goombaSpriteRightFoot[5] = @"|________________| ";
        goombaSpriteRightFoot[6] = @"      /    \ ____ ";
        goombaSpriteRightFoot[7] = @" ____|      /____\ ";
        goombaSpriteRightFoot[8] = @"/____\ ====         ";
        goombaSpriteRightFoot[9] = @"                     ";

    }
}