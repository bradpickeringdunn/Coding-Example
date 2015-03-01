<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CodingSkillExample.Models.WorkingDayViewModel>" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page - My ASP.NET MVC Application
</asp:Content>

<asp:Content ID="indexFeatured" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>CodingSkillExample Test.</h1>
            </hgroup>
            
            <%if (Model.Notifications.HasErrors)
              { %>
                 <p><%=Model.Notifications.Notifications.First().Error%></p>
             
            <%}
            
            if (!Model.Notifications.HasErrors)
              {%>
                  <p>
                      The next working day from today is: 
                      <span><%=Model.NextWorkingDay%></span>
                  </p>
              <%}%>


        </div>
    </section>
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <form action="/Home/NextWorkingDay" method="post">
        <p>Get the next working day from:</p>
        <div>
            <input type="date" name="Date" />
            <button type="submit" value="Get next working day">Get next working day</button>
        </div>
    </form>
</asp:Content>
