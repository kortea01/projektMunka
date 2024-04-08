import SideMenu from './SideMenu';
import { Outlet } from 'react-router-dom';


function Layout() {
    return (<>
        <div className='menu_container'>
            <SideMenu/>
        </div>
        <div className='main_container'>
        <main>
            <Outlet />
        </main>
        </div>
    </>);
}

export default Layout;