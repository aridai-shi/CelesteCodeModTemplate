
# aridai's Celeste Code Mod Template
A simple template forgetting started on Celeste code mods - from map-specific cutscenes to robust mapping helpers!
## DISCLAIMER
This is **not** intended to be used as a standalone mod. It's a template off which mods can be based.
Once downloaded, make sure to change the namespaces and data in everest.yaml, so there aren't any actual mods using "Template" as a name!
***If you are caught using the Template without changing the name, I will personally 🗞️bonk🗞️ you on Discord.***
## Usage
To use this template, you can fork it or clone it on here.
When distributing a codemod with a map, only add the DLL folder into the zip, and modify the mod's everest.yaml with this
```
- Name: YourModHere (any name will work)
  Version: 1.0.0 (any version will work)
  DLL: DLL/YourDLLHere.dll (must be the same name as the .dll in the DLL folder)
```
When making a helper, also copy over the Ahorn folder.
The Code folder stores all of the files you'll be storing the code in (usually .cs files)
The Ahorn folder stores all of the files needed to make your entities work in Ahorn (usually .jl files)
## Why?
TBH I was tired of repeating the Everest tutorial on the setup process *each and every time* I wanted to make a code-mod. However, this might also prove useful to people who find the setup process confusing, as well as other coders *tired of repeating the same thing over and over and over again*.

If there's jank involved, DM me on Discord: @aridai#3842
Have fun coding instead of wasting time on setup!
