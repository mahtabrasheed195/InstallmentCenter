<%@ Page Title="" Language="C#" MasterPageFile="~/ShowRoom.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ShowRoomManagementCenter.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Slider -->
    <%-- <div id="home">--%>
    <section class="carousel carousel-fade slide home-slider" id="c-slide" data-ride="carousel"
        data-interval="4500" data-pause="false">
	<ol class="carousel-indicators">
		<li data-target="#c-slide" data-slide-to="0" class="active"></li>
		<li data-target="#c-slide" data-slide-to="1" class=""></li>		
	</ol>
	<div class="carousel-inner">
		<div class="item active bg1">
			<div class="container">
				<div class="row">
					<div class="col-md-6 fadein scaleInv anim_1">
                    <br />
						<div class="fadein scaleInv anim_2">
							<h1 class="carouselText1 animated fadeInLeftBig">United MotorCycle  <span class="colortext">Sale Management System</span></h1>
						</div>
						<div class="fadein scaleInv anim_1">
							<p class="carouselText2 animated fadeInLeftBig">
								Installment Managment Center
							</p>
						</div>							
						
					</div>
					<div class="col-md-6 text-center fadein scaleInv anim_2">
						<div class="text-center">
							<div class="fadein scaleInv anim_3">
								<img src="imgH/slide1-3.png" alt="" class="slide1-3 animated fadeInRightBig" />
							</div>
							<div class="fadein scaleInv anim_8">
								<img src="imgH/slide-2.jpg" alt="" class="slide1-1 animated fadeInRightBig" />
							</div>
							<%--<div class="fadein scaleInv anim_5">
								<img src="imgH/slide1-2.png" alt="" class="slide1-2 animated fadeInRightBig" />
							</div>--%> 
						</div>
					</div>
				</div>
			</div>
		</div>
		<div class="item bg2">
			<div class="container">
				<div class="row">
					<div class="col-md-6 animated fadeInUp notransition">
                    <br />
						<img src="imgH/slide-1.png" alt="" style="width:90%;" />
					</div>
					<div class="col-md-6 animated fadeInDown  notransition topspace30 text-right">
						
						<br>
						<br>
						<br>
						<div class="car-highlight3 animated fadeInUpBig notransition">
							 An Insight to Your Daily , Weekly and Monthly Sales
						</div>
						<br>
						<div class="car-highlight4 animated flipInX notransition">
							Get Records of Your Sales, Buyers and Guarantors
						</div>
						<br>
						<div class="car-highlight5 animated rollIn notransition">
							 Total Control Over Reports
							 One-Click Solution 
						</div>
					</div>
				</div>
			</div>
		</div>
		
	</div>
	<!-- /.carousel-inner -->
	<a class="left carousel-control animated fadeInLeft" href="#c-slide" data-slide="prev"><i class="fa fa-arrow-left"></i></a>
	<a class="right carousel-control animated fadeInRight" href="#c-slide" data-slide="next"><i class="fa fa-arrow-right"></i></a>
	</section>
    <!-- /.carousel end-->
    <%--    </div>--%>
    <!-- Page Content -->
    <div class="container">
        <!-- Marketing Icons Section -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header wow fadeInLeft">
                    Welcome to <strong>United ShowRoom Management System</strong>
                </h1>
            </div>
            <div class="col-md-4">
                <div class="panel panel-info wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                    <div class="panel-heading">
                        <h4>
                            <i class="fa fa-fw fa-check"></i>Sell A Motor Cycle</h4>
                    </div>
                    <div class="panel-body">
                        <p>
                           .</p>
                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-info">Sell </asp:HyperLink>
                        <asp:LinkButton ID="lnkbootstrap1" runat="server" CssClass="btn btn-labeled btn-primary pull-right">
                                <span class="btn-label"><i class="fa fa-download"></i> </span>Link Button   
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="panel panel-danger wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                    <div class="panel-heading">
                        <h4>
                            <i class="fa fa-fw fa-gift"></i>Submit Installment</h4>
                    </div>
                    <div class="panel-body">
                        <p>
                           .</p>
                        <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-danger">Learn More</asp:HyperLink>
                          <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-labeled btn-danger pull-right">
                                <span class="btn-label"><i class="fa fa-download"></i> </span>Link Button   
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="panel panel-success wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                    <div class="panel-heading">
                        <h4>
                            <i class="fa fa-fw fa-compass"></i>Search </h4>
                    </div>
                    <div class="panel-body">
                        <p>
                            .
                        </p>
                        <asp:HyperLink ID="HyperLink3" runat="server" CssClass="btn btn-success">Learn More</asp:HyperLink>
                          <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-labeled btn-success pull-right">
                                <span class="btn-label"><i class="fa fa-download"></i> </span>Link Button   
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">

            <div class="col-md-4">
                <div class="panel panel-info wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                    <div class="panel-heading">
                        <h4>
                            <i class="fa fa-fw fa-check"></i>Daily Sale</h4>
                    </div>
                    <div class="panel-body">
                        <p>
                           .</p>
                        <asp:HyperLink ID="HyperLink4" runat="server" CssClass="btn btn-info">Sell </asp:HyperLink>
                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-labeled btn-primary pull-right">
                                <span class="btn-label"><i class="fa fa-download"></i> </span>Link Button   
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="panel panel-danger wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                    <div class="panel-heading">
                        <h4>
                            <i class="fa fa-fw fa-gift"></i>Monthly Sales</h4>
                    </div>
                    <div class="panel-body">
                        <p>
                           .</p>
                        <asp:HyperLink ID="HyperLink5" runat="server" CssClass="btn btn-danger">Learn More</asp:HyperLink>
                          <asp:LinkButton ID="LinkButton4" runat="server" CssClass="btn btn-labeled btn-danger pull-right">
                                <span class="btn-label"><i class="fa fa-download"></i> </span>Link Button   
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="panel panel-success wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                    <div class="panel-heading">
                        <h4>
                            <i class="fa fa-fw fa-compass"></i>Edit Installment Plan </h4>
                    </div>
                    <div class="panel-body">
                        <p>
                            .
                        </p>
                        <asp:HyperLink ID="HyperLink6" runat="server" CssClass="btn btn-success">Learn More</asp:HyperLink>
                          <asp:LinkButton ID="LinkButton5" runat="server" CssClass="btn btn-labeled btn-success pull-right">
                                <span class="btn-label"><i class="fa fa-download"></i> </span>Link Button   
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <!-- jQuery -->
    <script src="jsH/jquery.js" type="text/javascript"></script>
    <!-- Bootstrap Core JavaScript -->
    <script src="jsH/bootstrap.min.js" type="text/javascript"></script>
    <script src="jsH/wow.min.js" type="text/javascript"></script>
    <!-- Script to Activate the Carousel -->
    <script type="text/javascript">
        $('.carousel').carousel({
            interval: 5000 //changes the speed
        })
    </script>
</asp:Content>

