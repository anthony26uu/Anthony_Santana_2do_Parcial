﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Aula.Master" AutoEventWireup="true" CodeBehind="RProfesor.aspx.cs" Inherits="Anthony_Santana_2do_Parcial.Ui.Registros.RProfesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

    

    <!--Inclusión de Extras Para evitar Errores-->
    <script src="/Scripts/toastr.min.js"></script>
    <script src="/Scripts/jquery-2.2.0.min.js"></script>
    <script src="/Scripts/bootstrap.min.js"></script>

    <div class="text-center">
        <h3 class="page-header text-center">REGISTRO PROFESOR <span></span></h3>
    </div>

    <div class="text-center">
        <span class="badge badge-primary">ID</span><asp:TextBox ID="TextBoxID" TextMode="Number" class="input-lg" placeholder="ID a buscar " runat="server" Height="45px" Width="160px" ValidationGroup="buscar" MaxLength="10"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxID" ErrorMessage="**" Font-Bold="True" Font-Italic="True" ForeColor="Red" ValidationGroup="Buscar"></asp:RequiredFieldValidator>
        <asp:Button ID="BotonBuscar" CssClass=" btn btn-default" runat="server" Text="Buscar" Height="45px" ValidationGroup="Buscar"  Width="83px" OnClick="BotonBuscar_Click" />

        <br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxID" ErrorMessage="Solo Numeros y Numeros positivos" ForeColor="Red" ValidationExpression="\d+" ValidationGroup="Buscar"></asp:RegularExpressionValidator>

        <br />

        <br />
        <br />
        <span class="badge badge-primary">Nombres</span><br />

        <!--Texbox -->





        <asp:TextBox ID="TextBoxNombre" placeholder="Nombre " class="input-lg" runat="server" Height="30px" Width="215px" ValidationGroup="guardar" MaxLength="100"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxNombre" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>

        <br />

        <br />
        <span class="badge badge-primary">Nacimiento</span><br />

        <!--Texbox -->



        <asp:TextBox ID="TextFecha" class="input-lg" type="date" runat="server" Width="225px" Height="42px"></asp:TextBox>


        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxDireccion" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>

        <br />

        <br />


        <span class="badge badge-primary">Direccion</span><br />


        &nbsp;

       
          <!--Texbox -->

        <asp:TextBox ID="TextBoxDireccion" TextMode="MultiLine" placeholder="Direccion" class="input-lg" runat="server" Height="58px" Width="217px" ValidationGroup="guardar" MaxLength="200"></asp:TextBox>


        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxDireccion" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>


        <br />


        <br />

           <span class="badge badge-primary">Curso Impartido</span><br />


        &nbsp;

       
          <!--Texbox -->

        <asp:DropDownList ID="TextBoxCurso" runat="server" CssClass="btn btn-default" Height="42px" Width="199px">
        </asp:DropDownList>


        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxCurso" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>


        <br />


        <br />
        <span class="badge badge-primary">Cedula</span><br />


        <!--Texbox -->

        <asp:TextBox ID="TexboCedula" placeholder="000-0000000-0" class="input-lg" runat="server" Height="30px" Width="215px" ValidationGroup="guardar" MaxLength="11"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TexboCedula" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>

        <br />

        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="TexboCedula" ErrorMessage="Solo Numeros " ForeColor="Red" ValidationExpression="\d+" ValidationGroup="guardar"></asp:RegularExpressionValidator>

        <br />
        <span class="badge badge-primary">Email</span><br />

        <asp:TextBox ID="TexboEmail" placeholder="Email" class="input-lg" runat="server" Height="30px" Width="215px" ValidationGroup="guardar" MaxLength="20"></asp:TextBox>

        <!--Select -->

        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TexboEmail" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>

        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="TexboEmail"
            ErrorMessage="Correo no valido " SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
            ValidationGroup="guardar" CssClass="bg-danger"></asp:RegularExpressionValidator>&nbsp;

        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="TexboEmail"
            ErrorMessage="E-mail es requerido." ToolTip="E-mail is required." ValidationGroup="guardar">*</asp:RequiredFieldValidator>
        <br />

        <br />
        <span class="badge badge-primary">Telefono</span><br />

        <asp:TextBox ID="TexboTelefono" placeholder="000-000-0000" class="input-lg" runat="server"  Height="30px" Width="215px" ValidationGroup="guardar" MaxLength="10"></asp:TextBox>



        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TexboTelefono" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>

        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="TexboTelefono" ErrorMessage="Solo Numeros" ForeColor="Red" ValidationExpression="\d+" ValidationGroup="guardar"></asp:RegularExpressionValidator>

        <br />


        <br />
        <span class="badge badge-primary">Sueldo</span><br />

        <asp:TextBox ID="TextBoxSueldo" placeholder="10,000.00" class="input-lg" runat="server"  Height="30px" Width="215px" ValidationGroup="guardar" MaxLength="10"></asp:TextBox>



        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBoxSueldo" ErrorMessage="**" Font-Bold="True" ForeColor="Red" ValidationGroup="guardar"></asp:RequiredFieldValidator>

        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBoxSueldo" ErrorMessage="Solo Numeros" ForeColor="Red" ValidationExpression="\d+" ValidationGroup="guardar"></asp:RegularExpressionValidator>

        <br />

        <br />

        <span class="badge badge-primary">Sexo</span><br />

        <asp:DropDownList ID="DropSexo" runat="server" CssClass=" btn btn-default" class="btn-" Height="42px" Width="199px">
            <asp:ListItem>Masculino</asp:ListItem>
            <asp:ListItem>Femenino</asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />
    </div>




    <!--Botones -->

    <div class="modal-footer">
        <div class=" text-center">
            <asp:Button ID="ButtonNuevo" CssClass="btn btn-warning" runat="server" Text="Nuevo" Height="36px" Width="88px" OnClick="ButtonNuevo_Click" />
            <asp:Button ID="ButtGuardar" CssClass="btn btn-success" runat="server" Text="Guardar" Height="36px" Width="88px" ValidationGroup="guardar" OnClick="ButtGuardar_Click"  />
            <asp:Button ID="ButtonEliminar" CssClass="btn btn-danger" runat="server" Text="Eliminar" Height="36px" Width="88px" ValidationGroup="Buscar" OnClick="ButtonEliminar_Click"   />
        </div>
    </div>
</asp:Content>
