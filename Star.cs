class Star{
				private int posX;
                private string[] starSprite;
				
				public Star(int posX){
					//this sets the global variable to the current x
					this.posX=posX;
					starSprite= new string[6];
                    SetSprite(); //for star image to starSprite
					}
                private void SetSprite(){
                    //for store star image to star Sprite
                    starSprite[0] = @"          ";
                    starSprite[1] = @"  ___/\___";
                    starSprite[2] = @"  \  ||  / ";
                    starSprite[3] = @"  /__  __\";
                    starSprite[4] = @"     \/   ";
                    starSprite[5] = @"          "; 
                }

                public void DrawSprite(){
                    //draw sprite at posX
                    string spaces = "";
                    for(int i=0; i<this.posX; i++){
                        spaces+=" ";
                    }
                    foreach(string eachline in starSprite){
                        Console.WriteLine(spaces + eachline);
                    }
                }


}


