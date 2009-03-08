<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="UserDefault, App_Web_2ggda6sb" title="博客首页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="Server">
    <div id="top">
        <span></span><strong>全部文章</strong></div>
    <asp:DataList ID="dlViewUserArticle" runat="server" DataSourceID="odsArticle" DataKeyField="Id">
        <ItemTemplate>
            <h2 class="posttitle">
                <a href="article.aspx?aid=<%# Eval("id") %>">
                    <%# Eval("title") %>
                </a>
            </h2>
            <p class="postdate">
                <%# Eval("pubDate", "{0:G}")%>
            </p>
            <div class="content">
                <p>
                    <%# GetCut(Eval("Contents").ToString(),150) %> 
                </p>
                <p>
                    &raquo; <a href="article.aspx?aid=<%# Eval("id") %>">阅读全文</a></p>
            </div>
            <p class="postmetadata">
                &nbsp; 点击率: 
                    <%# Eval("Clicks")%>
                | 评论:<%#CommonHandler.GetCommentNumber(int.Parse(Eval("Id").ToString()))%>
            </p>
        </ItemTemplate>
    </asp:DataList>
    <asp:ObjectDataSource ID="odsArticle" runat="server" SelectMethod="GetArticleByUserId"
        TypeName="MyBlogBLL.ArticleManager">
        <SelectParameters>
            <asp:QueryStringParameter Name="userid" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderLeft" runat="Server">
</asp:Content>
