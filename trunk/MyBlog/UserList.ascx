<%@ control language="C#" autoeventwireup="true" inherits="UserList, App_Web_fqxm9s1m" %>
<DIV class=sambar>
<H2>用户列表┊Usure Line </H2>

    <ul>
        <asp:ObjectDataSource ID="odsUserList" runat="server" SelectMethod="GetAllUsers"
            TypeName="MyBlogBLL.UserManager"></asp:ObjectDataSource>
        <asp:DataList ID="dlUserList" runat="server" RepeatColumns="1" DataSourceID="odsUserList">
            <ItemTemplate>
                <li><a href="UserDefault.aspx?id=<%# Eval("Id") %>">
                    <%# Eval("Name") %>
                </a></li>
            </ItemTemplate>
        </asp:DataList>
    </ul>
</div>


