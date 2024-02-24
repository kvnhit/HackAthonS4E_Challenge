<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="HackathonS4EChallenge._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 style="margin-bottom: 16px" id="aspnetTitle">Hackathon S4E</h1>
            <p class="lead"> O Evento tem como prosposta descobrir novos talentos da tecnologia.</p>
            <p class="lead"> No primeiro dia de evento que aconteceu no dia 17/02, foram apresentados dois workshops,um sobre ASP.NET 
                e outro sobre SQL Server.
            </p>
        </section>
        <section class="col-md-4" aria-labelledby="hostingTitle">
            <h2 id="hostingTitle">O Desafio</h2>
            <p class="lead">
                O segundo dia do evento que aconteceu no dia 24/02, os participantes se reuniram em duplas e tiveram 
                que criar aplicações de acordo com o desafia passado. 
            </p>
            <ul>
                <li>Gerenciar Funcipnário</li>
                <li>Gerenciar Vendas</li>
                <li>Gerenciar Tarefas</li>
                <li>Gerenciar Disciplinas</li>
                <li>Gerenciar Conta Bancária</li>
            </ul>            
        </section>

       <section aria-labelledby="hostingTitle">
            
                <h3>A Dupla</h3>
                <p> Daniela Botelho  - <a class="btn btn-default" href="https://github.com/danibotelho">Github &raquo;</a></p>
                <p> Kevein Hitzschky - <a class="btn btn-default" href="https://github.com/kvnhit">Github &raquo;</a> </p>
       </section>
    </main>

</asp:Content>
