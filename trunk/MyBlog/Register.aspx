﻿<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Register, App_Web_2ggda6sb" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">

 <table width="60%" height="22" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td style="width: 10px"><img src="images/topleft.gif" width="10" height="28" /></td>
    <td bgcolor="#DDDDCC"><span class="STYLE1">注册新用户</span></td>
    <td width="10"><img src="images/topright.gif" width="10" height="28" /></td>
  </tr>
</table>


<table width="60%" height="22" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="2" bgcolor="#DDDDCC">&nbsp;</td>
    <td><div align="center">
      <table height="61" cellpadding="0" cellspacing="0">
        <tr>
          <td height="33" colspan="6"><p class="STYLE2">注册新帐户方便又容易</p></td>
        </tr>
        <tr>
          <td width="24%" align="center" valign="top" style="height: 26px">用户名</td>
          <td valign="top" width="37%" align="left" style="height: 26px">
          <asp:TextBox ID="txtLoginId" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLoginId"
                  ErrorMessage="*"></asp:RequiredFieldValidator></td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">
              昵称：</td>
          <td valign="top" width="37%" align="left">
          <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">密码：</td>
          <td valign="top" width="37%" align="left">
          <asp:TextBox ID="txtLoginPwd" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">确认密码：</td>
          <td valign="top" width="37%" align="left">
          <asp:TextBox ID="txtPwdAgain" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
          </td>          
        </tr>
         <tr>
          <td width="24%" height="26" align="center" valign="top">Email：</td>
          <td valign="top" width="37%" align="left">
              <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
              &nbsp;
          </td>          
        </tr>
        <tr>
          <td width="24%" height="26" align="center" valign="top">
              QQ：</td>
          <td valign="top" width="37%" align="left">
             <asp:TextBox ID="txtQQ" runat="server"></asp:TextBox>
              &nbsp;
          </td>          
        </tr>
        <tr>
          <td colspan="2" align="center"><asp:ImageButton id="btnRegister"  runat="server" ImageUrl="images/finish.jpg" OnClick="btnRegister_Click"></asp:ImageButton><asp:Literal id="ltMain" runat="server"></asp:Literal></td>           
        </tr>
      </table>
      <div class="STYLE5">---------------------------------------------------------</div>
    </div>	
    </td>
    <td width="2" bgcolor="#DDDDCC">&nbsp;</td>
  </tr>
</table>


<table width="60%" height="3" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="3" bgcolor="#DDDDCC"><img src="../Images/touming.gif" width="27" height="9" /></td>
  </tr>
</table>








</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderLeft" Runat="Server">
</asp:Content>

