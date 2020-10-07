# C# Source Generators Test

Oh boy. Where do I begin?

This feature is really promising. I love the idea. I've hacked together my own source generators in the past using MSBuild trickery, so a first-party solution is really exciting.

But writing them sucks.

.NET 5 is already at the release candidate stage. Source generators should be pretty polished by this point. As far as I can tell, they're still in the "we threw this together in a weekend for a demo Monday morning" phase of development.

Most of my complaints may come from a place of ignorance. I might just be doing things wrong. Even so, the lack of documentation is reason enough to complain.

## Runtime + LangVersion

Official recommendation going forward is to make everything .NET 5, unless you have a convincing reason not to. So, I tried writing my source generator in .NET 5, and the consuming project in .NET 5.

This went nowhere fast.

The only way I could get this to work is by setting my source generator to `netstandard2.0` and my consuming project to `netcoreapp3.1`. Not ideal.

On top of this, I had to explcitly set my language version to preview. Which, by the way, Visual Studio now _really_ doesn't want you to do. The dropdown is gone, replaced by a _helpful_ message telling you why you shouldn't be doing this.

Except for source generators, you _must_ do this. On the source generator side and the consuming side. Great.

## Debug Prompts

When using a source generator by project reference, even with no debug launch command to be found, Visual Studio asks you which debugger you would like to use around 10 times in a row every time you even think about changing any code. This results in productivity hovering around zero.

Why not just use VS Code or Rider instead, you might ask. Because neither of them support source generators yet.
