<%@ Page Title="" Language="C#" MasterPageFile="~/Aula.Master" AutoEventWireup="true" CodeBehind="CEstudiantes.aspx.cs" Inherits="Anthony_Santana_2do_Parcial.Ui.Consultas.CEstudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <!--Inclusión de Extras Para evitar Errores-->
    <script src="/Scripts/toastr.min.js"></script>
    <script src="/Scripts/jquery-2.2.0.min.js"></script>
    <script src="/Scripts/bootstrap.min.js"></script>

    <header>
        <h1 class="page-header text-center">ESTUDIANTES REGISTRADOS <span></span></h1>
    </header>

    <div class="text-center">

        <div class="container">
            <div class="col-12 col-sm-20  ">
                <div class="row">
                    <div class="center-block" style="overflow: auto; height: 121px;">
                        <asp:GridView ID="EstudiantesGrid" runat="server" CssClass="  table-responsive" HorizontalAlign="Center" Height="16px" Width="742px">
                            <AlternatingRowStyle BackColor="gray  " />
                            <FooterStyle BackColor="#CCCC99" />
                            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <br />

    <div class="modal-footer">
        <div class="text-center">
            <a href="#" class="btn-default">
                <span></span>Imprimir
            </a>
        </div>
    </div>

    <br />
</asp:Content>
