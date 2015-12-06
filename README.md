# VariableSizedWrapGrid Sample

The VariableSizedWrapGrid was a signature control in Windows 8.

When porting one of our existing apps from Windows 8.1 to Windows 10, we ran into the issue where our grouped VariableSizedWrapGrid did not wrap correctly and each group consisted out of a single column running out of the screen borders (the groups were placed horizontally to keep the same behavior as Windows 8.1 for this particular app). 

This repository contains a sample solution where I started from scratch to implement a grouped VariableSizedWrapGrid.

[![VariableSizedWrapGrid][1]][1] 

Blog post: http://www.bartlannoeye.com/blog/windows-10-grouped-variablesizedwrapgrid-similar-to-windows-8

####Used libraries:

 * [Prism for Windows Runtime](https://prismwindowsruntime.codeplex.com/) for BindableBase (copied class file)

 [1]: Screen01.png