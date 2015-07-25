#load "..\_References.fsx"

printfn "I am a sample script. Provide me with args -a through -c and i will print them below"

if Args.has "-a" then
    printfn "you have provided arg -a"
if Args.has "-b" then
    printfn "you have provided arg -b"
if Args.has "-c" then
    printfn "you have provided arg -c"
