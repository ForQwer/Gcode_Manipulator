# GCode Manipulator  
This is my first public project and my first attempt at working with C#. I would greatly appreciate any feedback or suggestions for improvement!



This project provides a utility to manipulate GCode files for 3D printing. Its primary use is to adjust the position of a part on the printer bed, with options to apply offsets and set the printer's origin based on its configuration. The tool is especially helpful for printers where homing occurs at maximum X or Y coordinates rather than at (0,0).  

## Key Features  
- **Printer Bed Adjustments:** Move parts around the bed of your 3D printer.  
- **Offset Configuration:** Apply precise offsets to your print's placement.  
- **Flexible Printer Origins:** Use checkboxes to define whether the printer origin is at the minimum or maximum X/Y.  
- **Top-Level Identifier:** Specify the line where the actual print starts, bypassing initialization, cleaning, flow checks, and other pre-print processes.  

## GCode Requirements  

For the program to function correctly, the GCode file must include the following lines at the beginning:  
```
;MINX: ----  
;MINY: ----  
;MAXX: ----  
;MAXY: ----  
```  

### Example GCode File  
Below is a sample of a valid GCode file:  
```  
;FLAVOR:Marlin  
;TIME:2692  
;Filament used: 2.48294m  
;Layer height: 0.2  
;MINX:20.000  
;MINY:87.435  
;MINZ:0.2  
;MAXX:70.130  
;MAXY:132.565  
;MAXZ:34.4  
;TARGET_MACHINE.NAME:Two Trees Sapphire Pro  
;MKSPREVIEWPROCESSED  
; Postprocessed by [MKS WiFi plugin](https://github.com/PrintMakerLab/mks-wifi-plugin)  
; simage=0  
; gimage=0  
;Generated with Cura_SteamEngine 5.9.0  
M140 S60  
M105  
M190 S60  
M104 S210  
M105  
M109 S210  
M82 ;absolute extrusion mode  
G28 ; Home  
M420 S1 ; Enable bed leveling using the stored mesh  
G92 E0 ; Reset Extruder  
G1 Z2.0 F3000 ; Move bed down  
G1 X-9879.900 Y-9680.000 Z0.28 F5000.0 ; Move to start position  
G1 X-9820.000 Y-9680.000 Z0.28 F1500.0 E15 ; Draw the first line  
G1 X-9820.000 Y-9681.000 Z0.28 F5000.0 ; Move to side a little  
G1 X-9879.900 Y-9681.000 Z0.28 F1500.0 E20 ; Draw the second line  
G1 X-9879.900 Y-9682.000 Z0.28 F5000.0 ; Move to side a little  
G1 X-9820.000 Y-9682.000 Z0.28 F1500.0 E25 ; Draw the third line  
G1 X-9820.000 Y-9683.000 Z0.28 F5000.0 ; Move to side a little  
G1 X-9879.900 Y-9683.000 Z0.28 F1500.0 E30 ; Draw the fourth line  
G92 E0 ; Reset Extruder  
G1 Z2.0 F3000 ; Move Bed up  
G92 E0  
G92 E0  
G1 F3600 E-5  
;LAYER_COUNT:172  
;LAYER:0  
M107  
G1 F300 Z0.5  
;MESH:Gantry v30.stl  
G0 F6000 X68.028 Y110.699 Z0.5  
;TYPE:WALL-INNER  
G1 F300 Z0.2  
G1 F3600 E0  
G1 F1800 X67.965 Y110.465 E0.00725  
...  
```  

## Usage  

1. **Prepare your GCode file** by ensuring it includes by default the required `;MINX`, `;MINY`, `;MAXX`, and `;MAXY` headers.  
2. **Configure offsets** and define the printer origin using the provided interface.  
3. **Specify the starting line** of the actual print using the top-level identifier text input.  

![image](https://github.com/user-attachments/assets/8766f6c4-0715-4fc3-be34-a49363c82e88)
