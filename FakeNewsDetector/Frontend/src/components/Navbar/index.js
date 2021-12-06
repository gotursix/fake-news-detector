import {
    Nav,
    NavLogo,
    NavLink,
    NavMenu,
} from "./NavbarComponents";


const Navbar = () => {
    return (
        <>
           <Nav>
                <NavLogo to="/">
                    Fake News Detector
                </NavLogo>

                <NavMenu>
                    <NavLink to="/">
                        Home
                    </NavLink>
                    <NavLink to="/Checklink">
                        Check Link
                    </NavLink>
                    <NavLink to="/History">
                        History
                    </NavLink>
                </NavMenu> 
           </Nav> 
        </>
    );
};
export default Navbar;
