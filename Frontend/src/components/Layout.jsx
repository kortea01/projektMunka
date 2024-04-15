import Navbar from './Navbar';

import { Outlet } from 'react-router-dom';
import './style.css';

function Layout() {
return(
    <div id="wrapper">
	<header class="header">
		<div class="container">
			<div class="row">
				<div class="col">
					<div class="header_content d-flex flex-row align-items-center justify-content-start">
						<div class="logo">
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
    <div>
        <Outlet />
    </div>
    </div>
)
//
//    return (
//    <div className='main_wrapper'>
//        <div className='menu_container'>
//            <div className='logo'>MyLoGo</div>
//            <Navbar/>
//        </div>
//        <div className='main_container'>
//        <main>
//            <Outlet />
//        </main>
//        </div>
//    </div>);
}

export default Layout;