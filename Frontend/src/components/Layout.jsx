import Navbar from './Navbar';
import Footer from './Footer';
import { Outlet } from 'react-router-dom';
import './style.css';

function Layout() {
return(
    <div id="wrapper">
	<header className="header">
		<div className="container">
			<div className="row">
				<div className="col">
					<div className="header_content d-flex flex-row align-items-center justify-content-start">
						<div className="logo">
							<a href="#">
								<div>BellaItalia</div>
								<div>restaurant</div>
							</a>
						</div>
                        <Navbar/>
					</div>
				</div>
			</div>
		</div>
	</header>
    <div className='navbarpic'></div>
    <div className='contentWrapper'>
        <Outlet />
		<Footer/>
	</div>
    </div>
		
)

};

export default Layout;