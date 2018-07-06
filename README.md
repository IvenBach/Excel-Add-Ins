# Excel-Add-Ins
Place to store utility Add-Ins I develop and/or use in Excel

To use these Add-ins you'll need to go to File>Options>Add-Ins>Manage: Excel Add-Ins>Go. This will bring up the Add-Ins dialog window. From there click the Browse... button and navigate to where you saved the add-in. Once done, the add-in will be available when you need to use them. As long as it's left enabled you'll have access to the add-in for any Excel file.

## SubSuperScripting
This add-in will allow easier sub and super scripting of text. Examples are when working with chemical equations such as CO<sub>2</sub>. It's tedious to continually have to go back and forth adding and removing the scripting effect to the characters of the cell. Wrapping text with the default strings of `_` and `^` results in the surrounded text having the correct scripting added. Alternate characters can be chosen as well.
 - Carbon Dioxide (CO2) would be written as CO_2_ and become CO<sub>2</sub>
 - Sulfate (SO42-) would be written as SO_4_^2-^  and become SO<sub>4</sub><sup>2-</sub>
 
## Ribbon UI Modifications
Requests from co-workers or things that irritated me about Excel are bundled into this Add-in.

Allows single click access to commands to built in commands. Instead of having to go through multiple windows they are now immediately accessible
 - R1C1 Reference Style
 - Display Page Break
 - Freeze/Re-Freese on ActiveCell
 - UnfreesePanes
 
Allows you to do things that by default aren't avalible.
 - Range Offset group (Left, Right, Up, Down)
 - Selection group Autofit Columns, Rows. AutoFits based on what's selected. Default behavior only allows an entire column to be AutoFit.