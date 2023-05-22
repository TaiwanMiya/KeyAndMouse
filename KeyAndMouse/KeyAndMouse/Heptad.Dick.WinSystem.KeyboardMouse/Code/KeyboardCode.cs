using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Code
{
    /// <summary>
    ///     所有鍵盤結構總匯
    /// </summary>
    public class Keycode
    {
        /// <summary>
        /// A鍵 結構
        /// </summary>
        public readonly struct A
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'A';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'A';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x41;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x1E;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.A;
        }
        /// <summary>
        /// B鍵 結構
        /// </summary>
        public readonly struct B
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'B';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'B';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x42;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x30;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.B;
        }
        /// <summary>
        /// C鍵 結構
        /// </summary>
        public readonly struct C
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'C';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'C';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x43;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x2E;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.C;
        }
        /// <summary>
        /// D鍵 結構
        /// </summary>
        public readonly struct D
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'D';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'D';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x44;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x20;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D;
        }
        /// <summary>
        /// E鍵 結構
        /// </summary>
        public readonly struct E
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'E';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'E';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x45;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x12;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.E;
        }
        /// <summary>
        /// F鍵 結構
        /// </summary>
        public readonly struct F
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'F';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'F';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x46;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x21;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F;
        }
        /// <summary>
        /// G鍵 結構
        /// </summary>
        public readonly struct G
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'G';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'G';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x47;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x22;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.G;
        }
        /// <summary>
        /// H鍵 結構
        /// </summary>
        public readonly struct H
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'H';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'H';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x48;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x23;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.H;
        }
        /// <summary>
        /// I鍵 結構
        /// </summary>
        public readonly struct I
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'I';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'I';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x49;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x17;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.I;
        }
        /// <summary>
        /// J鍵 結構
        /// </summary>
        public readonly struct J
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'J';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'J';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x4A;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x24;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.J;
        }
        /// <summary>
        /// K鍵 結構
        /// </summary>
        public readonly struct K
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'K';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'K';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x4B;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x25;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.K;
        }
        /// <summary>
        /// L鍵 結構
        /// </summary>
        public readonly struct L
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'L';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'L';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x4C;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x26;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.L;
        }
        /// <summary>
        /// M鍵 結構
        /// </summary>
        public readonly struct M
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'M';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'M';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x4D;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x32;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.M;
        }
        /// <summary>
        /// N鍵 結構
        /// </summary>
        public readonly struct N
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'N';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'N';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x4E;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x31;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.N;
        }
        /// <summary>
        /// O鍵 結構
        /// </summary>
        public readonly struct O
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'O';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'O';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x4F;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x18;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.O;
        }
        /// <summary>
        /// P鍵 結構
        /// </summary>
        public readonly struct P
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'P';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'P';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x50;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x19;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.P;
        }
        /// <summary>
        /// Q鍵 結構
        /// </summary>
        public readonly struct Q
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'Q';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'Q';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x51;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x10;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Q;
        }
        /// <summary>
        /// R鍵 結構
        /// </summary>
        public readonly struct R
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'R';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'R';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x52;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x13;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.R;
        }
        /// <summary>
        /// S鍵 結構
        /// </summary>
        public readonly struct S
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'S';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'S';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x53;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x1F;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.S;
        }
        /// <summary>
        /// T鍵 結構
        /// </summary>
        public readonly struct T
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'T';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'T';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x54;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x14;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.T;
        }
        /// <summary>
        /// U鍵 結構
        /// </summary>
        public readonly struct U
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'U';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'U';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x55;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x16;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.U;
        }
        /// <summary>
        /// V鍵 結構
        /// </summary>
        public readonly struct V
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'V';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'V';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x56;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x2F;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.V;
        }
        /// <summary>
        /// W鍵 結構
        /// </summary>
        public readonly struct W
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'W';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'W';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x57;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x11;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.W;
        }
        /// <summary>
        /// X鍵 結構
        /// </summary>
        public readonly struct X
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'X';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'X';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x58;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x2D;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.X;
        }
        /// <summary>
        /// Y鍵 結構
        /// </summary>
        public readonly struct Y
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'Y';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'Y';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x59;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x15;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Y;
        }
        /// <summary>
        /// Z鍵 結構
        /// </summary>
        public readonly struct Z
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = 'Z';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = 'Z';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x5A;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x2C;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Z;
        }

        /// <summary>
        /// 0鍵 結構
        /// </summary>
        public readonly struct _0
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = ')';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x30;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x0B;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D0;
        }
        /// <summary>
        /// 1鍵 結構
        /// </summary>
        public readonly struct _1
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '1';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '!';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x31;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x02;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D1;
        }
        /// <summary>
        /// 2鍵 結構
        /// </summary>
        public readonly struct _2
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '2';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '@';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x32;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x03;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D2;
        }
        /// <summary>
        /// 3鍵 結構
        /// </summary>
        public readonly struct _3
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '3';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '#';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x33;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x04;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D3;
        }
        /// <summary>
        /// 4鍵 結構
        /// </summary>
        public readonly struct _4
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '4';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '$';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x34;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x05;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D4;
        }
        /// <summary>
        /// 5鍵 結構
        /// </summary>
        public readonly struct _5
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '5';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '%';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x35;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x06;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D5;
        }
        /// <summary>
        /// 6鍵 結構
        /// </summary>
        public readonly struct _6
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '6';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '^';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x36;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x07;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D6;
        }
        /// <summary>
        /// 7鍵 結構
        /// </summary>
        public readonly struct _7
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '7';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '&';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x37;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x08;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D7;
        }
        /// <summary>
        /// 8鍵 結構
        /// </summary>
        public readonly struct _8
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '8';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '*';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x38;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x09;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D8;
        }
        /// <summary>
        /// 9鍵 結構
        /// </summary>
        public readonly struct _9
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '9';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '(';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x39;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x0A;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.D9;
        }
        /// <summary>
        /// 小鍵盤0鍵 結構
        /// </summary>
        public readonly struct NUM_0
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x60;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x52;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumPad0;
        }
        /// <summary>
        /// 小鍵盤1鍵 結構
        /// </summary>
        public readonly struct NUM_1
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '1';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '1';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x61;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x4F;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumPad1;
        }
        /// <summary>
        /// 小鍵盤2鍵 結構
        /// </summary>
        public readonly struct NUM_2
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '2';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '2';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x62;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x50;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumPad2;
        }
        /// <summary>
        /// 小鍵盤3鍵 結構
        /// </summary>
        public readonly struct NUM_3
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '3';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '3';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x63;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x51;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumPad3;
        }
        /// <summary>
        /// 小鍵盤4鍵 結構
        /// </summary>
        public readonly struct NUM_4
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '4';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '4';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x64;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x4B;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumPad4;
        }
        /// <summary>
        /// 小鍵盤5鍵 結構
        /// </summary>
        public readonly struct NUM_5
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '5';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '5';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x65;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x4C;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumPad5;
        }
        /// <summary>
        /// 小鍵盤6鍵 結構
        /// </summary>
        public readonly struct NUM_6
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '6';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '6';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x66;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x4D;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumPad6;
        }
        /// <summary>
        /// 小鍵盤7鍵 結構
        /// </summary>
        public readonly struct NUM_7
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '7';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '7';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x67;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x47;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumPad7;
        }
        /// <summary>
        /// 小鍵盤8鍵 結構
        /// </summary>
        public readonly struct NUM_8
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '8';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '8';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x68;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x48;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumPad8;
        }
        /// <summary>
        /// 小鍵盤9鍵 結構
        /// </summary>
        public readonly struct NUM_9
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '9';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '9';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x69;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x49;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumPad9;
        }

        /// <summary>
        /// F1鍵 結構
        /// </summary>
        public readonly struct F1
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x70;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x3B;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F1;
        }
        /// <summary>
        /// F2鍵 結構
        /// </summary>
        public readonly struct F2
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x71;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x3C;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F2;
        }
        /// <summary>
        /// F3鍵 結構
        /// </summary>
        public readonly struct F3
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x72;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x3D;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F3;
        }
        /// <summary>
        /// F4鍵 結構
        /// </summary>
        public readonly struct F4
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x73;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x3E;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F4;
        }
        /// <summary>
        /// F5鍵 結構
        /// </summary>
        public readonly struct F5
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x74;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x3F;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F5;
        }
        /// <summary>
        /// F6鍵 結構
        /// </summary>
        public readonly struct F6
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x75;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x40;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F6;
        }
        /// <summary>
        /// F7鍵 結構
        /// </summary>
        public readonly struct F7
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x76;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x41;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F7;
        }
        /// <summary>
        /// F8鍵 結構
        /// </summary>
        public readonly struct F8
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x77;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x42;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F8;
        }
        /// <summary>
        /// F9鍵 結構
        /// </summary>
        public readonly struct F9
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x78;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x43;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F9;
        }
        /// <summary>
        /// F10鍵 結構
        /// </summary>
        public readonly struct F10
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x79;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x44;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F10;
        }
        /// <summary>
        /// F11鍵 結構
        /// </summary>
        public readonly struct F11
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x7A;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x57;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F11;
        }
        /// <summary>
        /// F12鍵 結構
        /// </summary>
        public readonly struct F12
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x7B;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x58;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.F12;
        }
        /// <summary>
        /// 分號鍵 <b>;</b>
        /// 冒號鍵 <b>:</b>
        /// 結構
        /// </summary>
        public readonly struct COLON
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = ';';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = ':';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xBA;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x27;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.OemSemicolon;
        }
        /// <summary>
        /// 等號鍵 <b>=</b>
        /// 加號鍵 <b>+</b>
        /// 結構
        /// </summary>
        public readonly struct EQUAL
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '=';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '+';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xBB;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x0D;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Oemplus;
        }
        /// <summary>
        /// 逗號鍵 <b>,</b>
        /// 小於鍵 <b>&lt;</b>
        /// 結構
        /// </summary>
        public readonly struct COMMA
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = ',';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '<';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xBC;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x33;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Oemcomma;
        }
        /// <summary>
        /// 減號鍵 <b>-</b>
        /// 底線鍵 <b>_</b>
        /// 結構
        /// </summary>
        public readonly struct MINUS
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '-';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '_';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xBD;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x0C;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.OemMinus;
        }
        /// <summary>
        /// 句號鍵 <b>.</b>
        /// 大於鍵 <b>&gt;</b>
        /// 結構
        /// </summary>
        public readonly struct POINT
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '.';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '>';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xBE;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x34;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.OemPeriod;
        }
        /// <summary>
        /// 正斜線 <b>/</b>
        /// 問號鍵 <b>?</b>
        /// 結構
        /// </summary>
        public readonly struct SLASH
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '/';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '?';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xBF;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x35;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.OemQuestion;
        }
        /// <summary>
        /// 反引號 <b>`</b>
        /// 波浪符 <b>~</b>
        /// 結構
        /// </summary>
        public readonly struct BACKTICKS
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '`';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '~';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xC0;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x29;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Oemtilde;
        }
        /// <summary>
        /// 左中括號 <b>[</b>
        /// 左大括號 <b>{</b>
        /// 結構
        /// </summary>
        public readonly struct LEFT_BRACKETS
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '[';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '{';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xDB;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x1A;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.OemOpenBrackets;
        }
        /// <summary>
        /// 反斜線 <b>\</b>
        /// 垂直線 <b>|</b>
        /// 結構
        /// </summary>
        public readonly struct BACKSLASH
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\\';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '|';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xE2;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x2B;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.OemBackslash;
        }
        /// <summary>
        /// 右中括號 <b>]</b>
        /// 右大括號 <b>}</b>
        /// 結構
        /// </summary>
        public readonly struct RIGHT_BRACKETS
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = ']';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '}';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xDD;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x1B;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.OemCloseBrackets;
        }
        /// <summary>
        /// 單引號 <b>&apos;</b>
        /// 雙引號 <b>&quot;</b>
        /// 結構
        /// </summary>
        public readonly struct QUOTES
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\'';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '"';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xDE;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x28;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.OemQuotes;
        }
        /// <summary>
        /// 空格鍵 結構
        /// </summary>
        public readonly struct SPACE
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = ' ';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x20;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x39;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Space;
        }
        /// <summary>
        /// 退格鍵 結構
        /// </summary>
        public readonly struct BACK
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\x08';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x08;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x0E;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Back;

        }
        /// <summary>
        /// 輸入鍵 <b>\n</b>
        /// 結構,
        /// 其他同 <see cref="RETURN"/>
        /// </summary>
        public readonly struct ENTER
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\n';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x0D;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x1C;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Enter;
        }
        /// <summary>
        /// 回車鍵 <b>\r</b>
        /// 結構,
        /// 其他同 <see cref="ENTER"/>
        /// </summary>
        public readonly struct RETURN
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\r';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x0D;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x1C;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Return;
        }
        /// <summary>
        /// TAB鍵 <b>\t</b>
        /// 結構
        /// </summary>
        public readonly struct TAB
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\t';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x09;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x1F;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Tab;
        }
        /// <summary>
        /// 左 Shift 鍵 結構
        /// </summary>
        public readonly struct L_SHIFT
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xA0;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x2A;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.LShiftKey;
        }
        /// <summary>
        /// 右 Shift 鍵 結構
        /// </summary>
        public readonly struct R_SHIFT
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xA1;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x36;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.RShiftKey;
        }
        /// <summary>
        /// 左 Ctrl 鍵 結構
        /// </summary>
        public readonly struct L_CTRL
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xA2;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x1D;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.LControlKey;
        }
        /// <summary>
        /// 右 Ctrl 鍵 結構
        /// </summary>
        public readonly struct R_CTRL
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xA3;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x1D;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.RControlKey;
        }
        /// <summary>
        /// Alt 鍵 結構
        /// </summary>
        public readonly struct L_ALT
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xA4;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x38;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.LMenu;
        }
        /// <summary>
        /// Alt 鍵 結構
        /// </summary>
        public readonly struct R_ALT
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0xA5;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x38;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.RMenu;
        }
        /// <summary>
        /// CapsLock 鍵 大小寫切換鍵 結構
        /// </summary>
        public readonly struct CAPS
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x14;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x3A;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.CapsLock;
        }
        /// <summary>
        /// Esc 鍵 結構
        /// </summary>
        public readonly struct ESCAPE
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x1B;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x01;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Escape;
        }
        /// <summary>
        /// Delete 鍵 結構
        /// </summary>
        public readonly struct DELETE
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x2E;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x53;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Delete;
        }
        /// <summary>
        /// Insert 鍵 結構
        /// </summary>
        public readonly struct INSERT
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x2D;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x52;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Insert;
        }
        /// <summary>
        /// Windows 鍵 結構
        /// </summary>
        public readonly struct WINDOWS
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x5B;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0xE0 | 0x5B;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.LWin;
        }
        /// <summary>
        /// Num lock 鍵,
        /// 數字鎖定鍵
        /// 結構
        /// </summary>
        public readonly struct NUMLOCK
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x90;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x45;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.NumLock;
        }
        /// <summary>
        /// Scroll lock 鍵,
        /// 滾動鎖定鍵
        /// 結構
        /// </summary>
        public readonly struct SCROLL
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x91;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x46;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Scroll;
        }
        /// <summary>
        /// Print Screen 鍵,
        /// 螢幕截圖鍵
        /// 結構
        /// </summary>
        public readonly struct PRINT_SCREEN
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x2C;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x37;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.PrintScreen;
        }
        /// <summary>
        /// Home 鍵
        /// </summary>
        public readonly struct HOME
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x24;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x47;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Home;
        }
        /// <summary>
        /// End 鍵
        /// </summary>
        public readonly struct END
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x23;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x4F;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.End;
        }
        /// <summary>
        /// Page up 鍵,
        /// 上一頁,
        /// 結構
        /// </summary>
        public readonly struct PAGEUP
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x21;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x49;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.PageUp;
        }
        /// <summary>
        /// Page down 鍵,
        /// 下一頁,
        /// 結構
        /// </summary>
        public readonly struct PAGEDOWN
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x22;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x51;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.PageDown;
        }
        /// <summary>
        /// 方向鍵-上 結構
        /// </summary>
        public readonly struct ARROWUP
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x26;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x48;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Up;
        }
        /// <summary>
        /// 方向鍵-下 結構
        /// </summary>
        public readonly struct ARROWDOWN
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x28;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x50;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Down;
        }
        /// <summary>
        /// 方向鍵-左 結構
        /// </summary>
        public readonly struct ARROWLEFT
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x25;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x4B;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Left;
        }
        /// <summary>
        /// 方向鍵-右 結構
        /// </summary>
        public readonly struct ARROWRIGHT
        {
            /// <summary>
			/// 字節
			/// </summary>
            public const char name = '\0';
            /// <summary>
			/// shift 按下時的字節
			/// </summary>
            public const char shift_name = '\0';
            /// <summary>
			/// 虛擬鍵值
			/// </summary>
            public const byte virtualcode = 0x27;
            /// <summary>
			/// 鍵盤掃描碼
			/// </summary>
            public const byte scancode = 0x4D;
            /// <summary>
			/// <see cref="Keys"/> 的代表值
			/// </summary>
            public const Keys keys = Keys.Right;
        }
    }


    /// <summary>
    ///     <see cref="VirtualCode"/>
    ///     <para>
    ///         虛擬鍵碼
    ///     </para>
    ///     <para>
    ///         可參考 winuser.h 標頭檔, 前頭帶有 VK_ 的參數
    ///     </para>
    ///     <para>
    ///         這項資料對於所有計算機鍵盤而言, 都一定是相同的邏輯
    ///     </para>
    ///     <para>
    ///         [in] 虛擬鍵碼, 輸入方式在系統判定為軟體編碼
    ///     </para>
    /// </summary>
    public readonly struct VirtualCode
    {
        /// <summary>
        /// 滑鼠左鍵
        /// </summary>
        public const byte vKeyLButton = 0x1;
        /// <summary>
        /// 滑鼠右鍵
        /// </summary>
        public const byte vKeyRButton = 0x2;
        /// <summary>
        /// CANCEL 鍵
        /// </summary>
        public const byte vKeyCancel = 0x3;
        /// <summary>
        /// 滑鼠中鍵
        /// </summary>
        public const byte vKeyMButton = 0x4;
        /// <summary>
        /// BACKSPACE 鍵
        /// </summary>
        public const byte vKeyBack = 0x8;
        /// <summary>
        /// TAB 鍵
        /// </summary>
        public const byte vKeyTab = 0x9;
        /// <summary>
        /// CLEAR 鍵
        /// </summary>
        public const byte vKeyClear = 0xC;
        /// <summary>
        /// ENTER 鍵
        /// </summary>
        public const byte vKeyReturn = 0xD;
        /// <summary>
        /// SHIFT 鍵
        /// </summary>
        public const byte vKeyShift = 0x10;
        /// <summary>
        /// CTRL 鍵
        /// </summary>
        public const byte vKeyControl = 0x11;
        /// <summary>
        /// Alt 鍵  (鍵碼18)
        /// </summary>
        public const byte vKeyAlt = 18;
        /// <summary>
        /// MENU 鍵
        /// </summary>
        public const byte vKeyMenu = 0x12;
        /// <summary>
        /// PAUSE 鍵
        /// </summary>
        public const byte vKeyPause = 0x13;
        /// <summary>
        /// CAPS LOCK 鍵
        /// </summary>
        public const byte vKeyCapital = 0x14;
        /// <summary>
        /// ESC 鍵
        /// </summary>
        public const byte vKeyEscape = 0x1B;
        /// <summary>
        /// SPACEBAR 鍵
        /// </summary>
        public const byte vKeySpace = 0x20;
        /// <summary>
        /// PAGE UP 鍵
        /// </summary>
        public const byte vKeyPageUp = 0x21;
        /// <summary>
        /// End 鍵
        /// </summary>
        public const byte vKeyEnd = 0x23;
        /// <summary>
        /// HOME 鍵
        /// </summary>
        public const byte vKeyHome = 0x24;
        /// <summary>
        /// LEFT ARROW 鍵
        /// </summary>
        public const byte vKeyLeft = 0x25;
        /// <summary>
        /// UP ARROW 鍵
        /// </summary>
        public const byte vKeyUp = 0x26;
        /// <summary>
        /// RIGHT ARROW 鍵
        /// </summary>
        public const byte vKeyRight = 0x27;
        /// <summary>
        /// DOWN ARROW 鍵
        /// </summary>
        public const byte vKeyDown = 0x28;
        /// <summary>
        /// Select 鍵
        /// </summary>
        public const byte vKeySelect = 0x29;
        /// <summary>
        /// PRINT SCREEN 鍵
        /// </summary>
        public const byte vKeyPrint = 0x2A;
        /// <summary>
        /// EXECUTE 鍵
        /// </summary>
        public const byte vKeyExecute = 0x2B;
        /// <summary>
        /// SNAPSHOT 鍵
        /// </summary>
        public const byte vKeySnapshot = 0x2C;
        /// <summary>
        /// Delete 鍵
        /// </summary>
        public const byte vKeyDelete = 0x2E;
        /// <summary>
        /// HELP 鍵
        /// </summary>
        public const byte vKeyHelp = 0x2F;
        /// <summary>
        /// NUM LOCK 鍵
        /// </summary>
        public const byte vKeyNumlock = 0x90;
        /// <summary>
        /// A 鍵
        /// </summary>
        public const byte vKeyA = 65;
        /// <summary>
        /// B 鍵
        /// </summary>
        public const byte vKeyB = 66;
        /// <summary>
        /// C 鍵
        /// </summary>
        public const byte vKeyC = 67;
        /// <summary>
        /// D 鍵
        /// </summary>
        public const byte vKeyD = 68;
        /// <summary>
        /// E 鍵
        /// </summary>
        public const byte vKeyE = 69;
        /// <summary>
        /// F 鍵
        /// </summary>
        public const byte vKeyF = 70;
        /// <summary>
        /// G 鍵
        /// </summary>
        public const byte vKeyG = 71;
        /// <summary>
        /// H 鍵
        /// </summary>
        public const byte vKeyH = 72;
        /// <summary>
        /// I 鍵
        /// </summary>
        public const byte vKeyI = 73;
        /// <summary>
        /// J 鍵
        /// </summary>
        public const byte vKeyJ = 74;
        /// <summary>
        /// K 鍵
        /// </summary>
        public const byte vKeyK = 75;
        /// <summary>
        /// L 鍵
        /// </summary>
        public const byte vKeyL = 76;
        /// <summary>
        /// M 鍵
        /// </summary>
        public const byte vKeyM = 77;
        /// <summary>
        /// N 鍵
        /// </summary>
        public const byte vKeyN = 78;
        /// <summary>
        /// O 鍵
        /// </summary>
        public const byte vKeyO = 79;
        /// <summary>
        /// P 鍵
        /// </summary>
        public const byte vKeyP = 80;
        /// <summary>
        /// Q 鍵
        /// </summary>
        public const byte vKeyQ = 81;
        /// <summary>
        /// R 鍵
        /// </summary>
        public const byte vKeyR = 82;
        /// <summary>
        /// S 鍵
        /// </summary>
        public const byte vKeyS = 83;
        /// <summary>
        /// T 鍵
        /// </summary>
        public const byte vKeyT = 84;
        /// <summary>
        /// U 鍵
        /// </summary>
        public const byte vKeyU = 85;
        /// <summary>
        /// V 鍵
        /// </summary>
        public const byte vKeyV = 86;
        /// <summary>
        /// W 鍵
        /// </summary>
        public const byte vKeyW = 87;
        /// <summary>
        /// X 鍵
        /// </summary>
        public const byte vKeyX = 88;
        /// <summary>
        /// Y 鍵
        /// </summary>
        public const byte vKeyY = 89;
        /// <summary>
        /// Z 鍵
        /// </summary>
        public const byte vKeyZ = 90;
        /// <summary>
        /// 0 鍵
        /// </summary>
        public const byte vKey0 = 48;
        /// <summary>
        /// 1 鍵
        /// </summary>
        public const byte vKey1 = 49;
        /// <summary>
        /// 2 鍵
        /// </summary>
        public const byte vKey2 = 50;
        /// <summary>
        /// 3 鍵
        /// </summary>
        public const byte vKey3 = 51;
        /// <summary>
        /// 4 鍵
        /// </summary>
        public const byte vKey4 = 52;
        /// <summary>
        /// 5 鍵
        /// </summary>
        public const byte vKey5 = 53;
        /// <summary>
        /// 6 鍵
        /// </summary>
        public const byte vKey6 = 54;
        /// <summary>
        /// 7 鍵
        /// </summary>
        public const byte vKey7 = 55;
        /// <summary>
        /// 8 鍵
        /// </summary>
        public const byte vKey8 = 56;
        /// <summary>
        /// 9 鍵
        /// </summary>
        public const byte vKey9 = 57;
        /// <summary>
        /// 九宮格鍵 0 鍵
        /// </summary>
        public const byte vKeyNumpad0 = 0x60;
        /// <summary>
        /// 九宮格鍵 1 鍵
        /// </summary>
        public const byte vKeyNumpad1 = 0x61;
        /// <summary>
        /// 九宮格鍵 2 鍵
        /// </summary>
        public const byte vKeyNumpad2 = 0x62;
        /// <summary>
        /// 九宮格鍵 3 鍵
        /// </summary>
        public const byte vKeyNumpad3 = 0x63;
        /// <summary>
        /// 九宮格鍵 4 鍵
        /// </summary>
        public const byte vKeyNumpad4 = 0x64;
        /// <summary>
        /// 九宮格鍵 5 鍵
        /// </summary>
        public const byte vKeyNumpad5 = 0x65;
        /// <summary>
        /// 九宮格鍵 6 鍵
        /// </summary>
        public const byte vKeyNumpad6 = 0x66;
        /// <summary>
        /// 九宮格鍵 7 鍵
        /// </summary>
        public const byte vKeyNumpad7 = 0x67;
        /// <summary>
        /// 九宮格鍵 8 鍵
        /// </summary>
        public const byte vKeyNumpad8 = 0x68;
        /// <summary>
        /// 九宮格鍵 9 鍵
        /// </summary>
        public const byte vKeyNumpad9 = 0x69;
        /// <summary>
        /// MULTIPLICATIONSIGN(*)鍵
        /// </summary>
        public const byte vKeyMultiply = 0x6A;
        /// <summary>
        /// PLUS SIGN(+) 鍵
        /// </summary>
        public const byte vKeyAdd = 0x6B;
        /// <summary>
        /// ENTER 鍵
        /// </summary>
        public const byte vKeySeparator = 0x6C;
        /// <summary>
        /// MINUS SIGN(-) 鍵
        /// </summary>
        public const byte vKeySubtract = 0x6D;
        /// <summary>
        /// DECIMAL POINT(.) 鍵
        /// </summary>
        public const byte vKeyDecimal = 0x6E;
        /// <summary>
        /// DIVISION SIGN(/) 鍵
        /// </summary>
        public const byte vKeyDivide = 0x6F;
        /// <summary>
        /// F1 鍵
        /// </summary>
        public const byte vKeyF1 = 0x70;
        /// <summary>
        /// F2 鍵
        /// </summary>
        public const byte vKeyF2 = 0x71;
        /// <summary>
        /// F3 鍵
        /// </summary>
        public const byte vKeyF3 = 0x72;
        /// <summary>
        /// F4 鍵
        /// </summary>
        public const byte vKeyF4 = 0x73;
        /// <summary>
        /// F5 鍵
        /// </summary>
        public const byte vKeyF5 = 0x74;
        /// <summary>
        /// F6 鍵
        /// </summary>
        public const byte vKeyF6 = 0x75;
        /// <summary>
        /// F7 鍵
        /// </summary>
        public const byte vKeyF7 = 0x76;
        /// <summary>
        /// F8 鍵
        /// </summary>
        public const byte vKeyF8 = 0x77;
        /// <summary>
        /// F9 鍵
        /// </summary>
        public const byte vKeyF9 = 0x78;
        /// <summary>
        /// F10 鍵
        /// </summary>
        public const byte vKeyF10 = 0x79;
        /// <summary>
        /// F11 鍵
        /// </summary>
        public const byte vKeyF11 = 0x7A;
        /// <summary>
        /// F12 鍵
        /// </summary>
        public const byte vKeyF12 = 0x7B;
    }

    /// <summary>
    ///     <see cref="ScanCode"/>
    ///     <para>
    ///         鍵盤掃描碼
    ///     </para>
    ///     <para>
    ///         以行、列對映定位位置, 是電腦鍵盤向電腦傳送的一項資料
    ///     </para>
    ///     <para>
    ///         這項資料對於所有計算機鍵盤而言, 都一定是相同的邏輯
    ///     </para>
    ///     <para>
    ///         [in] 鍵盤掃瞄碼, 輸入方式在系統判定為硬體設備
    ///     </para>
    /// </summary>
    public enum ScanCode
    {
        /// <summary>
        /// A 鍵
        /// </summary>
        _A = 0x1E,
        /// <summary>
        /// B 鍵
        /// </summary>
        _B = 0x30,
        /// <summary>
        /// C 鍵
        /// </summary>
        _C = 0x2E,
        /// <summary>
        /// D 鍵
        /// </summary>
        _D = 0x20,
        /// <summary>
        /// E 鍵
        /// </summary>
        _E = 0x12,
        /// <summary>
        /// F 鍵
        /// </summary>
        _F = 0x21,
        /// <summary>
        /// G 鍵
        /// </summary>
        _G = 0x22,
        /// <summary>
        /// H 鍵
        /// </summary>
        _H = 0x23,
        /// <summary>
        /// I 鍵
        /// </summary>
        _I = 0x17,
        /// <summary>
        /// J 鍵
        /// </summary>
        _J = 0x24,
        /// <summary>
        /// K 鍵
        /// </summary>
        _K = 0x25,
        /// <summary>
        /// L 鍵
        /// </summary>
        _L = 0x26,
        /// <summary>
        /// M 鍵
        /// </summary>
        _M = 0x32,
        /// <summary>
        /// N 鍵
        /// </summary>
        _N = 0x31,
        /// <summary>
        /// O 鍵
        /// </summary>
        _O = 0x18,
        /// <summary>
        /// P 鍵
        /// </summary>
        _P = 0x19,
        /// <summary>
        /// Q 鍵
        /// </summary>
        _Q = 0x10,
        /// <summary>
        /// R 鍵
        /// </summary>
        _R = 0x13,
        /// <summary>
        /// S 鍵
        /// </summary>
        _S = 0x1F,
        /// <summary>
        /// T 鍵
        /// </summary>
        _T = 0x14,
        /// <summary>
        /// U 鍵
        /// </summary>
        _U = 0x16,
        /// <summary>
        /// V 鍵
        /// </summary>
        _V = 0x2F,
        /// <summary>
        /// W 鍵
        /// </summary>
        _W = 0x11,
        /// <summary>
        /// X 鍵
        /// </summary>
        _X = 0x2D,
        /// <summary>
        /// Y 鍵
        /// </summary>
        _Y = 0x15,
        /// <summary>
        /// Z 鍵
        /// </summary>
        _Z = 0x2C,
        /// <summary>
        /// 0 鍵
        /// </summary>
        _0 = 0x0B,
        /// <summary>
        /// 1 鍵
        /// </summary>
        _1 = 0x02,
        /// <summary>
        /// 2 鍵
        /// </summary>
        _2 = 0x03,
        /// <summary>
        /// 3 鍵
        /// </summary>
        _3 = 0x04,
        /// <summary>
        /// 4 鍵
        /// </summary>
        _4 = 0x05,
        /// <summary>
        /// 5 鍵
        /// </summary>
        _5 = 0x06,
        /// <summary>
        /// 6 鍵
        /// </summary>
        _6 = 0x07,
        /// <summary>
        /// 7 鍵
        /// </summary>
        _7 = 0x08,
        /// <summary>
        /// 8 鍵
        /// </summary>
        _8 = 0x09,
        /// <summary>
        /// 9 鍵
        /// </summary>
        _9 = 0x0A,
        /// <summary>
        /// ESC鍵
        /// </summary>
        ESC = 0x01,
        /// <summary>
        /// F1 鍵
        /// </summary>
        F1 = 0x3B,
        /// <summary>
        /// F2 鍵
        /// </summary>
        F2 = 0x3C,
        /// <summary>
        /// F3 鍵
        /// </summary>
        F3 = 0x3D,
        /// <summary>
        /// F4 鍵
        /// </summary>
        F4 = 0x3E,
        /// <summary>
        /// F5 鍵
        /// </summary>
        F5 = 0x3F,
        /// <summary>
        /// F6 鍵
        /// </summary>
        F6 = 0x40,
        /// <summary>
        /// F7 鍵
        /// </summary>
        F7 = 0x41,
        /// <summary>
        /// F8 鍵
        /// </summary>
        F8 = 0x42,
        /// <summary>
        /// F9 鍵
        /// </summary>
        F9 = 0x43,
        /// <summary>
        /// F10 鍵
        /// </summary>
        F10 = 0x44,
        /// <summary>
        /// F11 鍵
        /// </summary>
        F11 = 0x57,
        /// <summary>
        /// F12 鍵
        /// </summary>
        F12 = 0x58,
        /// <summary>
        /// 退格鍵
        /// </summary>
        BACK_SPACE = 0x0E,
        /// <summary>
        /// 空白鍵
        /// </summary>
        SPACE = 0x39,
        /// <summary>
        /// TAB鍵
        /// </summary>
        TAB = 0x0F,
        /// <summary>
        /// 大小寫切換鍵
        /// </summary>
        CAPS = 0x3A,
        /// <summary>
        /// 左SHIFT鍵
        /// </summary>
        SHIFT = 0x2A,
        /// <summary>
        /// 左CTRL鍵
        /// </summary>
        CTRL = 0x1D,
        /// <summary>
        /// 左ALT鍵
        /// </summary>
        ALT = 0x38,
        /// <summary>
        /// ENTER鍵 迴車鍵
        /// </summary>
        ENTER = 0x1C,
        /// <summary>
        /// 數字鍵盤鎖定鍵
        /// </summary>
        NUM_LOCK = 0x45,
        /// <summary>
        /// 滾動鎖定鍵
        /// </summary>
        SCROLL_LOCK = 0x46,
        /// <summary>
        /// 數字鍵盤 + 鍵
        /// </summary>
        NUM_PLUS = 0x4E,
        /// <summary>
        /// 數字鍵盤 - 鍵
        /// </summary>
        NUM_MINUS = 0x4A,
        /// <summary>
        /// 數字鍵盤 * 鍵
        /// </summary>
        NUM_MULTIPLY = 0x37,
        /// <summary>
        /// 數字鍵盤 . 鍵
        /// </summary>
        NUM_POINT = 0x53,
        /// <summary>
        /// 數字鍵盤 0 鍵
        /// </summary>
        NUM_0 = 0x52,
        /// <summary>
        /// 數字鍵盤 1 鍵
        /// </summary>
        NUM_1 = 0x4F,
        /// <summary>
        /// 數字鍵盤 2 鍵
        /// </summary>
        NUM_2 = 0x50,
        /// <summary>
        /// 數字鍵盤 3 鍵
        /// </summary>
        NUM_3 = 0x51,
        /// <summary>
        /// 數字鍵盤 4 鍵
        /// </summary>
        NUM_4 = 0x4B,
        /// <summary>
        /// 數字鍵盤 5 鍵
        /// </summary>
        NUM_5 = 0x4C,
        /// <summary>
        /// 數字鍵盤 6 鍵
        /// </summary>
        NUM_6 = 0x4D,
        /// <summary>
        /// 數字鍵盤 7 鍵
        /// </summary>
        NUM_7 = 0x47,
        /// <summary>
        /// 數字鍵盤 8 鍵
        /// </summary>
        NUM_8 = 0x48,
        /// <summary>
        /// 數字鍵盤 9 鍵
        /// </summary>
        NUM_9 = 0x49,
        /// <summary>
        /// [ { 鍵
        /// </summary>
        LEFT_BRACKETS = 0x1A,
        /// <summary>
        /// ] } 鍵
        /// </summary>
        RIGHT_BRACKETS = 0x1B,
        /// <summary>
        /// - _ 鍵
        /// </summary>
        MINUS = 0x0C,
        /// <summary>
        /// = + 鍵
        /// </summary>
        EQUAL = 0X0D,
        /// <summary>
        /// ; : 鍵
        /// </summary>
        COLON = 0x27,
        /// <summary>
        /// ' " 鍵
        /// </summary>
        QUOTES = 0x28,
        /// <summary>
        /// ` ~ 鍵
        /// </summary>
        BACKTICKS = 0x29,
        /// <summary>
        /// \ | 鍵
        /// </summary>
        BACKSLASH = 0x2B,
        /// <summary>
        /// , &lt; 鍵
        /// </summary>
        COMMA = 0x33,
        /// <summary>
        /// . &gt; 鍵
        /// </summary>
        POINT = 0X34,
        /// <summary>
        /// / ? 鍵
        /// </summary>
        SLASH = 0x35,
        /// <summary>
        /// 右SHIFT鍵
        /// </summary>
        R_SHIFT = 0x36,
        /// <summary>
        /// 右ALT鍵
        /// </summary>
        R_ALT = 0x54,
    }

    public class Keychars
    {
        /// <summary>
        ///     使用字節找到參數
        ///     <list type="bullet">
        ///         <item>
        ///             <see cref="char"/>
        ///             <para>
        ///                 字節
        ///             </para>
        ///         </item>
        ///         <item>
        ///             <see cref="byte"/>[]
        ///             <list type="bullet">
        ///                 <item>
        ///                     虛擬鍵碼
        ///                 </item>
        ///                 <item>
        ///                     鍵盤掃瞄碼
        ///                 </item>
        ///                 <item>
        ///                     是否需要按下功能鍵
        ///                     <list type="bullet">
        ///                         <item>
        ///                             <description>0 不動作</description>
        ///                         </item>
        ///                         <item>
        ///                             <description>1 Shift</description>
        ///                         </item>
        ///                         <item>
        ///                             <description>2 Caps Lock</description>
        ///                         </item>
        ///                     </list>
        ///                 </item>
        ///             </list>
        ///         </item>
        ///     </list>
        /// </summary>
        public static Dictionary<char, byte[]> DO { get; } = new Dictionary<char, byte[]>()
        {
            // 大寫
            { 'A' , new byte[] { Keycode.A.virtualcode, Keycode.A.scancode, 2} },
            { 'B' , new byte[] { Keycode.B.virtualcode, Keycode.B.scancode, 2} },
            { 'C' , new byte[] { Keycode.C.virtualcode, Keycode.C.scancode, 2} },
            { 'D' , new byte[] { Keycode.D.virtualcode, Keycode.D.scancode, 2} },
            { 'E' , new byte[] { Keycode.E.virtualcode, Keycode.E.scancode, 2} },
            { 'F' , new byte[] { Keycode.F.virtualcode, Keycode.F.scancode, 2} },
            { 'G' , new byte[] { Keycode.G.virtualcode, Keycode.G.scancode, 2} },
            { 'H' , new byte[] { Keycode.H.virtualcode, Keycode.H.scancode, 2} },
            { 'I' , new byte[] { Keycode.I.virtualcode, Keycode.I.scancode, 2} },
            { 'J' , new byte[] { Keycode.J.virtualcode, Keycode.J.scancode, 2} },
            { 'K' , new byte[] { Keycode.K.virtualcode, Keycode.K.scancode, 2} },
            { 'L' , new byte[] { Keycode.L.virtualcode, Keycode.L.scancode, 2} },
            { 'M' , new byte[] { Keycode.M.virtualcode, Keycode.M.scancode, 2} },
            { 'N' , new byte[] { Keycode.N.virtualcode, Keycode.N.scancode, 2} },
            { 'O' , new byte[] { Keycode.O.virtualcode, Keycode.O.scancode, 2} },
            { 'P' , new byte[] { Keycode.P.virtualcode, Keycode.P.scancode, 2} },
            { 'Q' , new byte[] { Keycode.Q.virtualcode, Keycode.Q.scancode, 2} },
            { 'R' , new byte[] { Keycode.R.virtualcode, Keycode.R.scancode, 2} },
            { 'S' , new byte[] { Keycode.S.virtualcode, Keycode.S.scancode, 2} },
            { 'T' , new byte[] { Keycode.T.virtualcode, Keycode.T.scancode, 2} },
            { 'U' , new byte[] { Keycode.U.virtualcode, Keycode.U.scancode, 2} },
            { 'V' , new byte[] { Keycode.V.virtualcode, Keycode.V.scancode, 2} },
            { 'W' , new byte[] { Keycode.W.virtualcode, Keycode.W.scancode, 2} },
            { 'X' , new byte[] { Keycode.X.virtualcode, Keycode.X.scancode, 2} },
            { 'Y' , new byte[] { Keycode.Y.virtualcode, Keycode.Y.scancode, 2} },
            { 'Z' , new byte[] { Keycode.Z.virtualcode, Keycode.Z.scancode, 2} },

            // 小寫
            { 'a' , new byte[] { Keycode.A.virtualcode, Keycode.A.scancode, 0} },
            { 'b' , new byte[] { Keycode.B.virtualcode, Keycode.B.scancode, 0} },
            { 'c' , new byte[] { Keycode.C.virtualcode, Keycode.C.scancode, 0} },
            { 'd' , new byte[] { Keycode.D.virtualcode, Keycode.D.scancode, 0} },
            { 'e' , new byte[] { Keycode.E.virtualcode, Keycode.E.scancode, 0} },
            { 'f' , new byte[] { Keycode.F.virtualcode, Keycode.F.scancode, 0} },
            { 'g' , new byte[] { Keycode.G.virtualcode, Keycode.G.scancode, 0} },
            { 'h' , new byte[] { Keycode.H.virtualcode, Keycode.H.scancode, 0} },
            { 'i' , new byte[] { Keycode.I.virtualcode, Keycode.I.scancode, 0} },
            { 'j' , new byte[] { Keycode.J.virtualcode, Keycode.J.scancode, 0} },
            { 'k' , new byte[] { Keycode.K.virtualcode, Keycode.K.scancode, 0} },
            { 'l' , new byte[] { Keycode.L.virtualcode, Keycode.L.scancode, 0} },
            { 'm' , new byte[] { Keycode.M.virtualcode, Keycode.M.scancode, 0} },
            { 'n' , new byte[] { Keycode.N.virtualcode, Keycode.N.scancode, 0} },
            { 'o' , new byte[] { Keycode.O.virtualcode, Keycode.O.scancode, 0} },
            { 'p' , new byte[] { Keycode.P.virtualcode, Keycode.P.scancode, 0} },
            { 'q' , new byte[] { Keycode.Q.virtualcode, Keycode.Q.scancode, 0} },
            { 'r' , new byte[] { Keycode.R.virtualcode, Keycode.R.scancode, 0} },
            { 's' , new byte[] { Keycode.S.virtualcode, Keycode.S.scancode, 0} },
            { 't' , new byte[] { Keycode.T.virtualcode, Keycode.T.scancode, 0} },
            { 'u' , new byte[] { Keycode.U.virtualcode, Keycode.U.scancode, 0} },
            { 'v' , new byte[] { Keycode.V.virtualcode, Keycode.V.scancode, 0} },
            { 'w' , new byte[] { Keycode.W.virtualcode, Keycode.W.scancode, 0} },
            { 'x' , new byte[] { Keycode.X.virtualcode, Keycode.X.scancode, 0} },
            { 'y' , new byte[] { Keycode.Y.virtualcode, Keycode.Y.scancode, 0} },
            { 'z' , new byte[] { Keycode.Z.virtualcode, Keycode.Z.scancode, 0} },

            // 數字
            { '0' , new byte[] { Keycode._0.virtualcode, Keycode._0.scancode, 0} },
            { '1' , new byte[] { Keycode._1.virtualcode, Keycode._1.scancode, 0} },
            { '2' , new byte[] { Keycode._2.virtualcode, Keycode._2.scancode, 0} },
            { '3' , new byte[] { Keycode._3.virtualcode, Keycode._3.scancode, 0} },
            { '4' , new byte[] { Keycode._4.virtualcode, Keycode._4.scancode, 0} },
            { '5' , new byte[] { Keycode._5.virtualcode, Keycode._5.scancode, 0} },
            { '6' , new byte[] { Keycode._6.virtualcode, Keycode._6.scancode, 0} },
            { '7' , new byte[] { Keycode._7.virtualcode, Keycode._7.scancode, 0} },
            { '8' , new byte[] { Keycode._8.virtualcode, Keycode._8.scancode, 0} },
            { '9' , new byte[] { Keycode._9.virtualcode, Keycode._9.scancode, 0} },

            // 需要shift的符號
            { ')' , new byte[] { Keycode._0.virtualcode, Keycode._0.scancode, 1} },
            { '!' , new byte[] { Keycode._1.virtualcode, Keycode._1.scancode, 1} },
            { '@' , new byte[] { Keycode._2.virtualcode, Keycode._2.scancode, 1} },
            { '#' , new byte[] { Keycode._3.virtualcode, Keycode._3.scancode, 1} },
            { '$' , new byte[] { Keycode._4.virtualcode, Keycode._4.scancode, 1} },
            { '%' , new byte[] { Keycode._5.virtualcode, Keycode._5.scancode, 1} },
            { '^' , new byte[] { Keycode._6.virtualcode, Keycode._6.scancode, 1} },
            { '&' , new byte[] { Keycode._7.virtualcode, Keycode._7.scancode, 1} },
            { '*' , new byte[] { Keycode._8.virtualcode, Keycode._8.scancode, 1} },
            { '(' , new byte[] { Keycode._9.virtualcode, Keycode._9.scancode, 1} },
            { ':' , new byte[] { Keycode.COLON.virtualcode, Keycode.COLON.scancode, 1} },
            { '+' , new byte[] { Keycode.EQUAL.virtualcode, Keycode.EQUAL.scancode, 1} },
            { '<' , new byte[] { Keycode.COMMA.virtualcode, Keycode.COMMA.scancode, 1} },
            { '_' , new byte[] { Keycode.MINUS.virtualcode, Keycode.MINUS.scancode, 1} },
            { '>' , new byte[] { Keycode.POINT.virtualcode, Keycode.POINT.scancode, 1} },
            { '?' , new byte[] { Keycode.SLASH.virtualcode, Keycode.SLASH.scancode, 1} },
            { '~' , new byte[] { Keycode.BACKTICKS.virtualcode, Keycode.BACKTICKS.scancode, 1} },
            { '{' , new byte[] { Keycode.LEFT_BRACKETS.virtualcode, Keycode.LEFT_BRACKETS.scancode, 1} },
            { '|' , new byte[] { Keycode.BACKSLASH.virtualcode, Keycode.BACKSLASH.scancode, 1} },
            { '}' , new byte[] { Keycode.RIGHT_BRACKETS.virtualcode, Keycode.RIGHT_BRACKETS.scancode, 1} },
            { '"' , new byte[] { Keycode.QUOTES.virtualcode, Keycode.QUOTES.scancode, 1} },

            // 不需要shift符號
            { ';' , new byte[] { Keycode.COLON.virtualcode, Keycode.COLON.scancode, 0} },
            { '=' , new byte[] { Keycode.EQUAL.virtualcode, Keycode.EQUAL.scancode, 0} },
            { ',' , new byte[] { Keycode.COMMA.virtualcode, Keycode.COMMA.scancode, 0} },
            { '-' , new byte[] { Keycode.MINUS.virtualcode, Keycode.MINUS.scancode, 0} },
            { '.' , new byte[] { Keycode.POINT.virtualcode, Keycode.POINT.scancode, 0} },
            { '/' , new byte[] { Keycode.SLASH.virtualcode, Keycode.SLASH.scancode, 0} },
            { '`' , new byte[] { Keycode.BACKTICKS.virtualcode, Keycode.BACKTICKS.scancode, 0} },
            { '[' , new byte[] { Keycode.LEFT_BRACKETS.virtualcode, Keycode.LEFT_BRACKETS.scancode, 0} },
            { '\\', new byte[] { Keycode.BACKSLASH.virtualcode, Keycode.BACKSLASH.scancode, 0} },
            { ']' , new byte[] { Keycode.RIGHT_BRACKETS.virtualcode, Keycode.RIGHT_BRACKETS.scancode, 0} },
            { '\'', new byte[] { Keycode.QUOTES.virtualcode, Keycode.QUOTES.scancode, 0} },

            // 特殊字元 - 0x80
            { ' ' , new byte[] { Keycode.SPACE.virtualcode, Keycode.SPACE.scancode, 0} },
            { '\n', new byte[] { Keycode.ENTER.virtualcode, Keycode.ENTER.scancode, 0} },
            { '\r', new byte[] { Keycode.RETURN.virtualcode, Keycode.RETURN.scancode, 0} },
            { '\t', new byte[] { Keycode.TAB.virtualcode, Keycode.TAB.scancode, 0} },
        };
    }

    /// <summary>
    /// 指定各種功能選項
    /// </summary>
    public struct keyFlags
    {
        /// <summary>
        /// 按鍵按下
        /// </summary>
        public const int KEYEVENTF_KEYDOWN       = 0x00;
        /// <summary>
        /// 如果指定, 鍵盤掃描碼前面加入一個值為 0xE0 (224) 的前綴字節
        /// </summary>
        public const int KEYEVENTF_EXTENDEDKEY  = 0x01;
        /// <summary>
        /// 按鍵鬆開
        /// </summary>
        public const int KEYEVENTF_KEYUP        = 0x02;
        /// <summary>
        /// 如果指定, 系統會合成一個VK_PACKET擊鍵, 此時虛擬鍵碼的參數必須為零
        /// </summary>
        public const int KEYEVENTF_UNICODE      = 0x04;
        /// <summary>
        /// 如果指定, 系統會識別鍵盤掃瞄碼, 並忽略虛擬鍵碼
        /// </summary>
        public const int KEYEVENTF_SCANCODE     = 0x08;
    }
}
