//# raylib 4.0 bindings.   Lgpl Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CsLo
{
    public static unsafe partial class RayGui
    {
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiEnable();

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiDisable();

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiLock();

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiUnlock();

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiIsLocked();

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiFade(float alpha);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetState(int state);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiGetState();

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetFont(Font font);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Font GuiGetFont();

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetStyle(int control, int property, int value);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiGetStyle(int control, int property);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiWindowBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* title);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiGroupBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiLine(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiPanel(Rectangle bounds);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Rectangle GuiScrollPanel(Rectangle bounds, Rectangle content, Vector2* scroll);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiLabel(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiButton(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiLabelButton(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiToggle(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, Boolean active);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiToggleGroup(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int active);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiCheckBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, Boolean @checked);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiComboBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int active);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiDropdownBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int* active, Boolean editMode);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiSpinner(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int* value, int minValue, int maxValue, Boolean editMode);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiValueBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int* value, int minValue, int maxValue, Boolean editMode);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiTextBox(Rectangle bounds, [NativeTypeName("char *")] sbyte* text, int textSize, Boolean editMode);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiTextBoxMulti(Rectangle bounds, [NativeTypeName("char *")] sbyte* text, int textSize, Boolean editMode);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GuiSlider(Rectangle bounds, [NativeTypeName("const char *")] sbyte* textLeft, [NativeTypeName("const char *")] sbyte* textRight, float value, float minValue, float maxValue);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GuiSliderBar(Rectangle bounds, [NativeTypeName("const char *")] sbyte* textLeft, [NativeTypeName("const char *")] sbyte* textRight, float value, float minValue, float maxValue);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GuiProgressBar(Rectangle bounds, [NativeTypeName("const char *")] sbyte* textLeft, [NativeTypeName("const char *")] sbyte* textRight, float value, float minValue, float maxValue);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiStatusBar(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiDummyRec(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiScrollBar(Rectangle bounds, int value, int minValue, int maxValue);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GuiGrid(Rectangle bounds, float spacing, int subdivs);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiListView(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int* scrollIndex, int active);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiListViewEx(Rectangle bounds, [NativeTypeName("const char **")] sbyte** text, int count, int* focus, int* scrollIndex, int active);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiMessageBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("const char *")] sbyte* message, [NativeTypeName("const char *")] sbyte* buttons);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiTextInputBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("const char *")] sbyte* message, [NativeTypeName("const char *")] sbyte* buttons, [NativeTypeName("char *")] sbyte* text);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color GuiColorPicker(Rectangle bounds, Color color);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color GuiColorPanel(Rectangle bounds, Color color);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GuiColorBarAlpha(Rectangle bounds, float alpha);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GuiColorBarHue(Rectangle bounds, float value);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiLoadStyle([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiLoadStyleDefault();

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GuiIconText(int iconId, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiDrawIcon(int iconId, int posX, int posY, int pixelSize, Color color);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int *")]
        public static extern uint* GuiGetIcons();

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int *")]
        public static extern uint* GuiGetIconData(int iconId);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetIconData(int iconId, [NativeTypeName("unsigned int *")] uint* data);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetIconPixel(int iconId, int x, int y);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiClearIconPixel(int iconId, int x, int y);

        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Boolean GuiCheckIconPixel(int iconId, int x, int y);

        [NativeTypeName("#define RAYGUI_VERSION \"3.0\"")]
        public static ReadOnlySpan<byte> RAYGUI_VERSION => new byte[] { 0x33, 0x2E, 0x30, 0x00 };
    }
}