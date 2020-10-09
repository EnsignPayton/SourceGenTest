# C# Source Generators Test

Thanks to this article for some pointers:

https://nicksnettravels.builttoroam.com/debug-code-gen/

This definitely took some fiddling to get working. The user experience is very _not good_ at the moment.

Some things to keep in mind:

* The generator must target `netstandard2.0` with a language version of `preview`
* Check if your debugger is attached before attaching a new one, else you'll have a bad time
* If things get wonky, restart VS. And maybe delete `.vs`, `obj`, and `bin` while you're at it.
