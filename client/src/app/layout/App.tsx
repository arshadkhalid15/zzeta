import { Container, containerClasses, createTheme, CssBaseline, ThemeProvider } from "@mui/material";
import { useState } from "react";
import { Route, Routes } from "react-router-dom";
import AboutPage from "../../features/about/AboutPage";
import Catalog from "../../features/catalog/Catalog";
import ProductDetails from "../../features/catalog/ProductDetails";
import ContactPage from "../../features/contact/ContactPage";
import HomePage from "../../features/home/HomePage";
import Header from "./Header";


function App() {
  const [darkMode, setDarkmode]=useState(false);
  const paletteType=darkMode ? 'dark' : 'light';
  const theme=createTheme({
    palette: {
      mode: paletteType,
      background:{
        default: paletteType==='light' ? '#eaeaea' : '#121212'
      }
    }
  })

  function handleThemeChange(){
    setDarkmode(!darkMode);
  }
  
  return (
    <ThemeProvider theme={theme}>
      <CssBaseline/>
      <Header darkMode={darkMode} handleThemeChange={handleThemeChange}/>
      <Routes>
        <Route path="/" element={<HomePage/>} />
        <Route path='/catalog' element={<Catalog/>} />
        <Route path='/catalog/:id' element={<ProductDetails/>} />
        <Route path='/about' element={<AboutPage/>} />
        <Route path='/contact' element={<ContactPage/>} />
      </Routes>
    </ThemeProvider>
  );
}
export default App;