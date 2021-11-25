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
                    <NavLink to="/" activeStyle>
                        Home
                    </NavLink>
                    <NavLink to="/Checklink" activeStyle>
                        Check Link
                    </NavLink>
                    <NavLink to="/History" activeStyle>
                        History
                    </NavLink>
                </NavMenu> 
           </Nav> 
        </>
    );
};
export default Navbar;
