<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ShoppingMail.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="border .1px solid red">
                <tr>
                    <td colspan="2">
                        <h2>User Resgitration</h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Email</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="100px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server"
                            ErrorMessage="Email is required" ForeColor="Red" ControlToValidate="txtEmail" Display="Dynamic"
                            text="*" ValdationExpreesion="\w+{[-+.']\w)*@\w+[-.]\w*\.\w+([-.]\w+)*">        

                        </asp:RequiredFieldValidator><asp:RegularExpressionValidator 
                            ID="RegularExpressionValidator1" runat="server"
                            ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>User Name</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" Width="100px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server"
                            ErrorMessage="Username is required" ForeColor="Red" ControlToValidate="txtUsername" Display="Dynamic"
                            text="*" <%--ValdationExpreesion="\w+{[-+.']\w)*@\w+[-.]\w*\.\w+([-.]\w+)*"--%>>   

                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Password</b>
                    </td>
                    <td>
                         <asp:TextBox ID="txtPassword" runat="server" Width="100px" TextMode="Password"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server"
                              ErrorMessage="Password is required" ForeColor="Red" ControlToValidate="txtPassword">

                          </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Confirm Password</b>
                    </td>
                    <td>
                         <asp:TextBox ID="txtConfirmPassword" runat="server" Width="100px" TextMode="Password"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword" runat="server"
                                 ErrorMessage="Password and ConfirmPassword must much" ForeColor="Red" 
                             ControlToValidate="ConfirmPassword" ControlToCompare="txtPassword" Display="Dynamic" Operator="Equal" Type="String">

                         </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" text="Save" />
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
