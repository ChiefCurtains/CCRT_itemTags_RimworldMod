First of all, thank you XeoNovaDan for sharing your source online! It was immensely helpful in writing this mod and I definitely... borrowed... a significant amount of your code.
This is my very first attempt at writing anything in C# and I know for a fact that I would not have been able to do it without heavily referencing your work!
I might be able to use this for something "throw new NotImplementedException($"Tried to draw trade icon for {trad} but {thing} not Tagged");"

vvv FOR THOSE WHO WISH TO MODIFY ANYTHING  vvv

I use the "ccrt_" (simplified Chief_Curtains) prefix to define which part of my code is touching the save file.
If you decide to add new tags or heavily modify any tags here, make your own short form prefix so that debugging can be simpler.
Also, if I decide to make any updates to the mod or add new tags, I will used the prefix "ccrt_XXXXX". If you do the same, there will be a conflict when I push a new build out.

All tags which are scribed onto the save file are proceeded with "ccrt_" in order to facilitate debugging, save cleaning, and error reporting. 
This is the only section that touches the save file.
A tag which will appear as <ccrt_******tag> </ccrt_******tag> will be appended at the end of the tagged entity. 
This placement will be effected by mod load order but is irrelevant.
Section in quotes dictates the actual scribed name in the save file.
