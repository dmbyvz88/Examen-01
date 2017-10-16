<%@ Page Title="" Language="C#" MasterPageFile="~/paginaMaestra.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Examen_01.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ol class="carousel-indicators">
                <li data-target="#main-slider" data-slide-to="0" class="active"></li>
                <li data-target="#main-slider" data-slide-to="1"></li>
                <li data-target="#main-slider" data-slide-to="2"></li>
    </ol>
    <div class="carousel-inner">
                <div class="item active" style="background-image: url(img/slides/1.png)">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="carousel-content centered">
                                    <h2 class="animation animated-item-1">Bienvenidos al taller SOCATELA-TUERCA S.A.</h2>
                                    <p class="animation animated-item-2">Estamos para solucionar sus distintos problemas mecánicos.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div><!--/.item-->
                <div class="item" style="background-image: url(img/slides/2.png)">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="carousel-content center centered">
                                    <h2 class="animation animated-item-1">Mantenimiento preventivo</h2>
                                    <%--<p class="animation animated-item-2">Phasellus adipiscing felis a dictum dictum. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec at ligula risus. </p>--%>
                                    <br>
                                    <a class="btn btn-md animation animated-item-3" href="#">Más...</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div><!--/.item-->
                <div class="item" style="background-image: url(img/slides/3.png)">
                    <div class="container">
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="carousel-content centered">
                                    <h2 class="animation animated-item-1">Previo a RTV.</h2>
                                    <p class="animation animated-item-2">Realizamos revición preliminar para la RTV.</p>
                                    <br>
									<%--<a class="btn btn-md animation animated-item-3" href="#">L</a>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </div><!--/.item-->
            </div><!--/.carousel-inner-->
</asp:Content>
