using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Code
{
	public class WMcode
	{
		/// <summary>
		/// 建立一個視窗
		/// </summary>
		public const int WM_CREATE = 0x01;
		/// <summary>
		/// 當一個視窗被破壞時傳送
		/// </summary>
		public const int WM_DESTROY = 0x02;
		/// <summary>
		/// 移動一個視窗
		/// </summary>
		public const int WM_MOVE = 0x03;
		/// <summary>
		/// 改變一個視窗的大小
		/// </summary>
		public const int WM_SIZE = 0x05;
		/// <summary>
		/// 一個視窗被啟用或失去啟用狀態
		/// </summary>
		public const int WM_ACTIVATE = 0x06;
		/// <summary>
		/// 一個視窗獲得焦點
		/// </summary>
		public const int WM_SETFOCUS = 0x07;
		/// <summary>
		/// 一個視窗失去焦點
		/// </summary>
		public const int WM_KILLFOCUS = 0x08;
		/// <summary>
		/// 一個視窗改變成Enable狀態
		/// </summary>
		public const int WM_ENABLE = 0x0A;
		/// <summary>
		/// 設定視窗是否能重畫
		/// </summary>
		public const int WM_SETREDRAW = 0x0B;
		/// <summary>
		/// 應用程式傳送此訊息來設定一個視窗的文字
		/// </summary>
		public const int WM_SETTEXT = 0x0C;
		/// <summary>
		/// 應用程式傳送此訊息來複制對應視窗的文字到緩衝區
		/// </summary>
		public const int WM_GETTEXT = 0x0D;
		/// <summary>
		/// 得到與一個視窗有關的文字的長度（不包含空字元）
		/// </summary>
		public const int WM_GETTEXTLENGTH = 0x0E;
		/// <summary>
		/// 要求一個視窗重畫自己
		/// </summary>
		public const int WM_PAINT = 0x0F;
		/// <summary>
		/// 當一個視窗或應用程式要關閉時傳送一個訊號
		/// </summary>
		public const int WM_CLOSE = 0x10;
		/// <summary>
		/// 當用戶選擇結束對話方塊或程式自己呼叫ExitWindows函式
		/// </summary>
		public const int WM_QUERYENDSESSION = 0x11;
		/// <summary>
		/// 用來結束程式執行
		/// </summary>
		public const int WM_QUIT = 0x12;
		/// <summary>
		/// 當用戶視窗恢復以前的大小位置時，把此訊息傳送給某個圖示
		/// </summary>
		public const int WM_QUERYOPEN = 0x13;
		/// <summary>
		/// 當視窗背景必須被擦除時（例在視窗改變大小時）
		/// </summary>
		public const int WM_ERASEBKGND = 0x14;
		/// <summary>
		/// 當系統顏色改變時，傳送此訊息給所有頂級視窗
		/// </summary>
		public const int WM_SYSCOLORCHANGE = 0x15;
		/// <summary>
		/// 當系統程序發出WM_QUERYENDSESSION訊息後，此訊息傳送給應用程式，通知它對話是否結束
		/// </summary>
		public const int WM_ENDSESSION = 0x16;
		/// <summary>
		/// 當隱藏或顯示視窗是傳送此訊息給這個視窗
		/// </summary>
		public const int WM_SHOWWINDOW = 0x18;
		/// <summary>
		/// 發此訊息給應用程式哪個視窗是啟用的，哪個是非啟用的
		/// </summary>
		public const int WM_ACTIVATEAPP = 0x1C;
		/// <summary>
		/// 當系統的字型資源庫變化時傳送此訊息給所有頂級視窗
		/// </summary>
		public const int WM_FONTCHANGE = 0x1D;
		/// <summary>
		/// 當系統的時間變化時傳送此訊息給所有頂級視窗
		/// </summary>
		public const int WM_TIMECHANGE = 0x1E;
		/// <summary>
		/// 傳送此訊息來取消某種正在進行的摸態（操作）
		/// </summary>
		public const int WM_CANCELMODE = 0x1F;
		/// <summary>
		/// 如果滑鼠引起游標在某個視窗中移動且滑鼠輸入沒有被捕獲時，就發訊息給某個視窗
		/// </summary>
		public const int WM_SETCURSOR = 0x20;
		/// <summary>
		/// 當游標在某個非啟用的視窗中而使用者正按著滑鼠的某個鍵傳送此訊息給
		/// 當前視窗
		/// </summary>
		public const int WM_MOUSEACTIVATE = 0x21;
		/// <summary>
		/// 傳送此訊息給MDI子視窗
		/// 當用戶點選此視窗的標題欄，或
		/// 當視窗被啟用，移動，改變大小
		/// </summary>
		public const int WM_CHILDACTIVATE = 0x22;
		/// <summary>
		/// 此訊息由基於計算機的訓練程式傳送，通過WH_JOURNALPALYBACK的hook程式分離出使用者輸入訊息
		/// </summary>
		public const int WM_QUEUESYNC = 0x23;
		/// <summary>
		/// 此訊息傳送給視窗當它將要改變大小或位置
		/// </summary>
		public const int WM_GETMINMAXINFO = 0x24;
		/// <summary>
		/// 傳送給最小化視窗當它圖示將要被重畫
		/// </summary>
		public const int WM_PAINTICON = 0x26;
		/// <summary>
		/// 此訊息傳送給某個最小化視窗，僅
		/// 當它在畫圖示前它的背景必須被重畫
		/// </summary>
		public const int WM_ICONERASEBKGND = 0x27;
		/// <summary>
		/// 傳送此訊息給一個對話方塊程式去更改焦點位置
		/// </summary>
		public const int WM_NEXTDLGCTL = 0x28;
		/// <summary>
		/// 每當列印管理列隊增加或減少一條作業時發出此訊息 
		/// </summary>
		public const int WM_SPOOLERSTATUS = 0x2A;
		/// <summary>
		/// 當button，combobox，listbox，menu的可視外觀改變時傳送
		/// </summary>
		public const int WM_DRAWITEM = 0x2B;
		/// <summary>
		/// 當button, combo box, list box, list view control, or menu item 被建立時
		/// </summary>
		public const int WM_MEASUREITEM = 0x2C;
		/// <summary>
		/// 此訊息有一個LBS_WANTKEYBOARDINPUT風格的發出給它的所有者來響應WM_KEYDOWN訊息 
		/// </summary>
		public const int WM_VKEYTOITEM = 0x2E;
		/// <summary>
		/// 此訊息由一個LBS_WANTKEYBOARDINPUT風格的列表框傳送給他的所有者來響應WM_CHAR訊息 
		/// </summary>
		public const int WM_CHARTOITEM = 0x2F;
		/// <summary>
		/// 當繪製文字時程式傳送此訊息得到控制元件要用的顏色
		/// </summary>
		public const int WM_SETFONT = 0x30;
		/// <summary>
		/// 應用程式傳送此訊息得到當前控制元件繪製文字的字型
		/// </summary>
		public const int WM_GETFONT = 0x31;
		/// <summary>
		/// 應用程式傳送此訊息讓一個視窗與一個熱鍵相關連 
		/// </summary>
		public const int WM_SETHOTKEY = 0x32;
		/// <summary>
		/// 應用程式傳送此訊息來判斷熱鍵與某個視窗是否有關聯
		/// </summary>
		public const int WM_GETHOTKEY = 0x33;
		/// <summary>
		/// 此訊息傳送給最小化視窗，當此視窗將要被拖放而它的類中沒有定義圖示，應用程式能返回一個圖示或游標的控制代碼，當用戶拖放圖示時系統顯示這個圖示或游標
		/// </summary>
		public const int WM_QUERYDRAGICON = 0x37;
		/// <summary>
		/// 傳送此訊息來判定combobox或listbox新增加的項的相對位置
		/// </summary>
		public const int WM_COMPAREITEM = 0x39;
		/// <summary>
		/// 顯示記憶體已經很少了
		/// </summary>
		public const int WM_COMPACTING = 0x41;
		/// <summary>
		/// 傳送此訊息給那個視窗的大小和位置將要被改變時，來呼叫setwindowpos函式或其它視窗管理函式
		/// </summary>
		public const int WM_WINDOWPOSCHANGING = 0x46;
		/// <summary>
		/// 傳送此訊息給那個視窗的大小和位置已經被改變時，來呼叫setwindowpos函式或其它視窗管理函式
		/// </summary>
		public const int WM_WINDOWPOSCHANGED = 0x47;
		/// <summary>
		/// 當系統將要進入暫停狀態時傳送此訊息
		/// </summary>
		public const int WM_POWER = 0x48;
		/// <summary>
		/// 當一個應用程式傳遞資料給另一個應用程式時傳送此訊息
		/// </summary>
		public const int WM_COPYDATA = 0x4A;
		/// <summary>
		/// 當某個使用者取消程式日誌啟用狀態，提交此訊息給程式
		/// </summary>
		public const int WM_CANCELJOURNA = 0x4B;
		/// <summary>
		/// 當某個控制元件的某個事件已經發生或這個控制元件需要得到一些資訊時，傳送此訊息給它的父視窗 
		/// </summary>
		public const int WM_NOTIFY = 0x4E;
		/// <summary>
		/// 當用戶選擇某種輸入語言，或輸入語言的熱鍵改變
		/// </summary>
		public const int WM_INPUTLANGCHANGEREQUEST = 0x50;
		/// <summary>
		/// 當平臺現場已經被改變後傳送此訊息給受影響的最頂級視窗
		/// </summary>
		public const int WM_INPUTLANGCHANGE = 0x51;
		/// <summary>
		/// 當程式已經初始化windows幫助例程時傳送此訊息給應用程式
		/// </summary>
		public const int WM_TCARD = 0x52;
		/// <summary>
		/// 此訊息顯示使用者按下了F1，如果某個選單是啟用的，就傳送此訊息個此視窗關聯的選單，否則就傳送給有焦點的視窗，如果
		/// 當前都沒有焦點，就把此訊息傳送給
		/// 當前啟用的視窗
		/// </summary>
		public const int WM_HELP = 0x53;
		/// <summary>
		/// 當用戶已經登入或退出後傳送此訊息給所有的視窗，
		/// 當用戶登入或退出時系統更新使用者的具體設定資訊，在使用者更新設定時系統馬上傳送此訊息
		/// </summary>
		public const int WM_USERCHANGED = 0x54;
		/// <summary>
		/// 公用控制元件，自定義控制元件和他們的父視窗通過此訊息來判斷控制元件是使用ANSI還是UNICODE結構
		/// </summary>
		public const int WM_NOTIFYFORMAT = 0x55;
		/// <summary>
		/// 當用戶某個視窗中點選了一下右鍵就傳送此訊息給這個視窗
		/// public const int WM_CONTEXTMENU = ??;
		/// 當呼叫SETWINDOWLONG函式將要改變一個或多個 視窗的風格時傳送此訊息給那個視窗
		/// </summary>
		public const int WM_STYLECHANGING = 0x7C;
		/// <summary>
		/// 當呼叫SETWINDOWLONG函式一個或多個 視窗的風格後傳送此訊息給那個視窗
		/// </summary>
		public const int WM_STYLECHANGED = 0x7D;
		/// <summary>
		/// 當顯示器的解析度改變後傳送此訊息給所有的視窗
		/// </summary>
		public const int WM_DISPLAYCHANGE = 0x7E;
		/// <summary>
		/// 此訊息傳送給某個視窗來返回與某個視窗有關連的大圖示或小圖示的控制代碼
		/// </summary>
		public const int WM_GETICON = 0x7F;
		/// <summary>
		/// 程式傳送此訊息讓一個新的大圖示或小圖示與某個視窗關聯
		/// </summary>
		public const int WM_SETICON = 0x80;
		/// <summary>
		/// 當某個視窗第一次被建立時，此訊息在WM_CREATE訊息傳送前傳送
		/// </summary>
		public const int WM_NCCREATE = 0x81;
		/// <summary>
		/// 此訊息通知某個視窗，非客戶區正在銷燬 
		/// </summary>
		public const int WM_NCDESTROY = 0x82;
		/// <summary>
		/// 當某個視窗的客戶區域必須被核算時傳送此訊息
		/// </summary>
		public const int WM_NCCALCSIZE = 0x83;
		/// <summary>
		/// 移動滑鼠，按住或釋放滑鼠時發生
		/// </summary>
		public const int WM_NCHITTEST = 0x84;
		/// <summary>
		/// 程式傳送此訊息給某個視窗當它（視窗）的框架必須被繪製時
		/// </summary>
		public const int WM_NCPAINT = 0x85;
		/// <summary>
		/// 此訊息傳送給某個視窗僅當它的非客戶區需要被改變來顯示是啟用還是非啟用狀態
		/// </summary>
		public const int WM_NCACTIVATE = 0x86;
		/// <summary>
		/// 傳送此訊息給某個與對話方塊程式關聯的控制元件，widdows控制方位鍵和TAB鍵使輸入進入此控制元件通過應
		/// </summary>
		public const int WM_GETDLGCODE = 0x87;
		/// <summary>
		/// 當游標在一個視窗的非客戶區內移動時傳送此訊息給這個視窗 非客戶區為：窗體的標題欄及窗 的邊框體
		/// </summary>
		public const int WM_NCMOUSEMOVE = 0xA0;
		/// <summary>
		/// 當游標在一個視窗的非客戶區同時按下滑鼠左鍵時提交此訊息
		/// </summary>
		public const int WM_NCLBUTTONDOWN = 0xA1;
		/// <summary>
		/// 當用戶釋放滑鼠左鍵同時游標某個視窗在非客戶區十發送此訊息 
		/// </summary>
		public const int WM_NCLBUTTONUP = 0xA2;
		/// <summary>
		/// 當用戶雙擊滑鼠左鍵同時游標某個視窗在非客戶區十發送此訊息
		/// </summary>
		public const int WM_NCLBUTTONDBLCLK = 0xA3;
		/// <summary>
		/// 當用戶按下滑鼠右鍵同時游標又在視窗的非客戶區時傳送此訊息
		/// </summary>
		public const int WM_NCRBUTTONDOWN = 0xA4;
		/// <summary>
		/// 當用戶釋放滑鼠右鍵同時游標又在視窗的非客戶區時傳送此訊息
		/// </summary>
		public const int WM_NCRBUTTONUP = 0xA5;
		/// <summary>
		/// 當用戶雙擊滑鼠右鍵同時游標某個視窗在非客戶區十發送此訊息
		/// </summary>
		public const int WM_NCRBUTTONDBLCLK = 0xA6;
		/// <summary>
		/// 當用戶按下滑鼠中鍵同時游標又在視窗的非客戶區時傳送此訊息
		/// </summary>
		public const int WM_NCMBUTTONDOWN = 0xA7;
		/// <summary>
		/// 當用戶釋放滑鼠中鍵同時游標又在視窗的非客戶區時傳送此訊息
		/// </summary>
		public const int WM_NCMBUTTONUP = 0xA8;
		/// <summary>
		/// 當用戶雙擊滑鼠中鍵同時游標又在視窗的非客戶區時傳送此訊息
		/// </summary>
		public const int WM_NCMBUTTONDBLCLK = 0xA9;
		/// <summary>
		/// WM_KEYDOWN 按下一個鍵
		/// </summary>
		public const int WM_KEYDOWN = 0x0100;
		/// <summary>
		/// 釋放一個鍵
		/// </summary>
		public const int WM_KEYUP = 0x0101;
		/// <summary>
		/// 按下某鍵，並已發出WM_KEYDOWN， WM_KEYUP訊息
		/// </summary>
		public const int WM_CHAR = 0x102;
		/// <summary>
		/// 當用translatemessage函式翻譯WM_KEYUP訊息時傳送此訊息給擁有焦點的視窗
		/// </summary>
		public const int WM_DEADCHAR = 0x103;
		/// <summary>
		/// 當用戶按住ALT鍵同時按下其它鍵時提交此訊息給擁有焦點的視窗
		/// </summary>
		public const int WM_SYSKEYDOWN = 0x104;
		/// <summary>
		/// 當用戶釋放一個鍵同時ALT 鍵還按著時提交此訊息給擁有焦點的視窗
		/// </summary>
		public const int WM_SYSKEYUP = 0x105;
		/// <summary>
		/// 當WM_SYSKEYDOWN訊息被TRANSLATEMESSAGE函式翻譯後提交此訊息給擁有焦點的視窗
		/// </summary>
		public const int WM_SYSCHAR = 0x106;
		/// <summary>
		/// 當WM_SYSKEYDOWN訊息被TRANSLATEMESSAGE函式翻譯後傳送此訊息給擁有焦點的視窗
		/// </summary>
		public const int WM_SYSDEADCHAR = 0x107;
		/// <summary>
		/// 在一個對話方塊程式被顯示前傳送此訊息給它，通常用此訊息初始化控制元件和執行其它任務
		/// </summary>
		public const int WM_INITDIALOG = 0x110;
		/// <summary>
		/// 當用戶選擇一條選單命令項或當某個控制元件傳送一條訊息給它的父視窗，一個快捷鍵被翻譯
		/// </summary>
		public const int WM_COMMAND = 0x111;
		/// <summary>
		/// 當用戶選擇視窗選單的一條命令或
		/// 當用戶選擇最大化或最小化時那個視窗會收到此訊息
		/// </summary>
		public const int WM_SYSCOMMAND = 0x112;
		/// <summary>
		/// 發生了定時器事件
		/// </summary>
		public const int WM_TIMER = 0x113;
		/// <summary>
		/// 當一個視窗標準水平滾動條產生一個滾動事件時傳送此訊息給那個視窗，也傳送給擁有它的控制元件
		/// </summary>
		public const int WM_HSCROLL = 0x114;
		/// <summary>
		/// 當一個視窗標準垂直滾動條產生一個滾動事件時傳送此訊息給那個視窗也，傳送給擁有它的控制元件
		/// </summary>
		public const int WM_VSCROLL = 0x115;
		/// <summary>
		/// 當一個選單將要被啟用時傳送此訊息，它發生在使用者選單條中的某項或按下某個選單鍵，它允許程式在顯示前更改選單
		/// </summary>
		public const int WM_INITMENU = 0x116;
		/// <summary>
		/// 當一個下拉選單或子選單將要被啟用時傳送此訊息，它允許程式在它顯示前更改選單，而不要改變全部
		/// </summary>
		public const int WM_INITMENUPOPUP = 0x117;
		/// <summary>
		/// 當用戶選擇一條選單項時傳送此訊息給選單的所有者（一般是視窗）
		/// </summary>
		public const int WM_MENUSELECT = 0x11F;
		/// <summary>
		/// 當選單已被啟用使用者按下了某個鍵（不同於加速鍵），傳送此訊息給選單的所有者
		/// </summary>
		public const int WM_MENUCHAR = 0x120;
		/// <summary>
		/// 當一個模態對話方塊或選單進入空載狀態時傳送此訊息給它的所有者，一個模態對話方塊或選單進入空載狀態就是在處理完一條或幾條先前的訊息後沒有訊息它的列隊中等待
		/// </summary>
		public const int WM_ENTERIDLE = 0x121;
		/// <summary>
		/// 在windows繪製訊息框前傳送此訊息給訊息框的所有者視窗，通過響應這條訊息，所有者視窗可以通過使用給定的相關顯示裝置的控制代碼來設定訊息框的文字和背景顏色
		/// </summary>
		public const int WM_CTLCOLORMSGBOX = 0x132;
		/// <summary>
		/// 當一個編輯型控制元件將要被繪製時傳送此訊息給它的父視窗通過響應這條訊息，所有者視窗可以通過使用給定的相關顯示裝置的控制代碼來設定編輯框的文字和背景顏色
		/// </summary>
		public const int WM_CTLCOLOREDIT = 0x133;

		/// <summary>
		/// 當一個列表框控制元件將要被繪製前傳送此訊息給它的父視窗通過響應這條訊息，所有者視窗可以通過使用給定的相關顯示裝置的控制代碼來設定列表框的文字和背景顏色
		/// </summary>
		public const int WM_CTLCOLORLISTBOX = 0x134;
		/// <summary>
		/// 當一個按鈕控制元件將要被繪製時傳送此訊息給它的父視窗通過響應這條訊息，所有者視窗可以通過使用給定的相關顯示裝置的控制代碼來設定按紐的文字和背景顏色
		/// </summary>
		public const int WM_CTLCOLORBTN = 0x135;
		/// <summary>
		/// 當一個對話方塊控制元件將要被繪製前傳送此訊息給它的父視窗通過響應這條訊息，所有者視窗可以通過使用給定的相關顯示裝置的控制代碼來設定對話方塊的文字背景顏色
		/// </summary>
		public const int WM_CTLCOLORDLG = 0x136;
		/// <summary>
		/// 當一個滾動條控制元件將要被繪製時傳送此訊息給它的父視窗通過響應這條訊息，所有者視窗可以通過使用給定的相關顯示裝置的控制代碼來設定滾動條的背景顏色
		/// </summary>
		public const int WM_CTLCOLORSCROLLBAR = 0x137;
		/// <summary>
		/// 當一個靜態控制元件將要被繪製時傳送此訊息給它的父視窗通過響應這條訊息，所有者視窗可以 通過使用給定的相關顯示裝置的控制代碼來設定靜態控制元件的文字和背景顏色
		/// </summary>
		public const int WM_CTLCOLORSTATIC = 0x138;
		/// <summary>
		/// 當滑鼠輪子轉動時傳送此訊息個當前有焦點的控制元件
		/// </summary>
		public const int WM_MOUSEWHEEL = 0x20A;
		/// <summary>
		/// 移動滑鼠時發生，同WM_MOUSEFIRST
		/// </summary>
		public const int WM_MOUSEMOVE = 0x200;
		/// <summary>
		/// 釋放滑鼠左鍵
		/// </summary>
		public const int WM_LBUTTONUP = 0x201;
		/// <summary>
		/// 按下滑鼠左鍵
		/// </summary>
		public const int WM_LBUTTONDOWN = 0x202;
		/// <summary>
		/// 雙擊滑鼠左鍵
		/// </summary>
		public const int WM_LBUTTONDBLCLK = 0x203;
		/// <summary>
		/// 釋放滑鼠右鍵
		/// </summary>
		public const int WM_RBUTTONUP = 0x204;
		/// <summary>
		/// 按下滑鼠右鍵
		/// </summary>
		public const int WM_RBUTTONDOWN = 0x205;
		/// <summary>
		/// 雙擊滑鼠右鍵
		/// </summary>
		public const int WM_RBUTTONDBLCLK = 0x206;
		/// <summary>
		/// 釋放滑鼠中鍵
		/// </summary>
		public const int WM_MBUTTONUP = 0x207;
		/// <summary>
		/// 按下滑鼠中鍵
		/// </summary>
		public const int WM_MBUTTONDOWN = 0x208;
		/// <summary>
		/// 雙擊滑鼠中鍵
		/// </summary>
		public const int WM_MBUTTONDBLCLK = 0x209;
	}
}
