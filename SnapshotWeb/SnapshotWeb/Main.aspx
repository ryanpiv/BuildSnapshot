<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="SnapshotWeb.Main"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Begin CSS linking -->
    <link href="CSS/Bootstrap/bootstrap.min.css" rel="Stylesheet" type="text/css" />
    <link href="CSS/StyleSheet1.css" rel="Stylesheet" type="text/css" />
    <!-- Begin JS linking -->
</head>
<body>
    <form id="form1" runat="server">
        <div class="container container-frame">
            <div class="row">
                <div class="col-md-12 main-header-frame">
                    <h1>
                        Snapshot Web</h1>
                </div>
                <legend></legend>

                <!-- Environment selection -->
                <section class="frame environments">
                    <div class="col-md-12">
                        <h3>Select Environment</h3>
                        <legend></legend>
                    </div>

                    <div class="col-sm-6 col-md-4 cb-environments">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" 
                    RepeatDirection="Horizontal">
                            <asp:ListItem>QD1</asp:ListItem>
                            <asp:ListItem>QD2</asp:ListItem>
                            <asp:ListItem>QD3</asp:ListItem>
                            <asp:ListItem>QD4</asp:ListItem>
                            <asp:ListItem>QD5</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>

                    <div class="col-sm-6 col-md-4">
                        <asp:CheckBoxList ID="CheckBoxList3" runat="server" 
                    RepeatDirection="Horizontal">
                            <asp:ListItem>TD1</asp:ListItem>
                            <asp:ListItem>TD2</asp:ListItem>
                            <asp:ListItem>TD3</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>

                    <div class="col-sm-6 col-md-4 cb-environments">
                        <asp:CheckBoxList ID="CheckBoxList4" runat="server" 
                    RepeatDirection="Horizontal">
                            <asp:ListItem>PROD</asp:ListItem>
                            <asp:ListItem>PROD-STG</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                </section>

                <!-- GAID selection -->
                <section class="frame gaid">
                    <div class="col-sm-12">
                        <h3>
                            Select GAID</h3>
                        <legend></legend>
                    </div>
                    <div class="col-sm-6 col-md-3 col-lg-2">
                        <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                            <asp:ListItem>5340</asp:ListItem>
                            <asp:ListItem>5357</asp:ListItem>
                            <asp:ListItem>5560</asp:ListItem>
                            <asp:ListItem>5678</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                    <div class="col-sm-6 col-md-3 col-lg-2">
                        <asp:CheckBoxList ID="CheckBoxList5" runat="server">
                            <asp:ListItem>5340</asp:ListItem>
                            <asp:ListItem>5357</asp:ListItem>
                            <asp:ListItem>5560</asp:ListItem>
                            <asp:ListItem>5678</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                    <div class="col-sm-6 col-md-3 col-lg-2">
                        <asp:CheckBoxList ID="CheckBoxList6" runat="server">
                            <asp:ListItem>5340</asp:ListItem>
                            <asp:ListItem>5357</asp:ListItem>
                            <asp:ListItem>5560</asp:ListItem>
                            <asp:ListItem>5678</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                    <div class="col-sm-6 col-md-3 col-lg-2">
                        <asp:CheckBoxList ID="CheckBoxList7" runat="server">
                            <asp:ListItem>5340</asp:ListItem>
                            <asp:ListItem>5357</asp:ListItem>
                            <asp:ListItem>5560</asp:ListItem>
                            <asp:ListItem>5678</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                    <div class="col-sm-6 col-md-3 col-lg-2">
                        <asp:CheckBoxList ID="CheckBoxList8" runat="server">
                            <asp:ListItem>5340</asp:ListItem>
                            <asp:ListItem>5357</asp:ListItem>
                            <asp:ListItem>5560</asp:ListItem>
                            <asp:ListItem>5678</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                    <div class="col-sm-6 col-md-3 col-lg-2">
                        <asp:CheckBoxList ID="CheckBoxList9" runat="server">
                            <asp:ListItem>5340</asp:ListItem>
                            <asp:ListItem>5357</asp:ListItem>
                            <asp:ListItem>5560</asp:ListItem>
                            <asp:ListItem>5678</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                </section>

                <!-- Manual Override -->
                <section class="frame">
                    <div style="width: max; height: auto" class="col-md-6 frame manual-override">
                        <asp:CheckBox ID="CheckBox1" runat="server" />Manual Override
                        <br />
                        <asp:TextBox CssClass="form-control" Rows="3" ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </section>

            </div>
            <div class="row">
                <div class="col-sm-12 btn-snapshot-div btn-snapshot-update">
                    <asp:Label CssClass="label label-success" ID="lblUpdate" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="col-sm-12 btn-snapshot-div">
                    <asp:Button CssClass="btn btn-primary btn-snapshot" ID="Button1" runat="server" 
                        Text="Snapshot" onclick="Button1_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
