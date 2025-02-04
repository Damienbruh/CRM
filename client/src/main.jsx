import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter, Routes, Route} from "react-router";

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <BrowserRouter>
        <Routes>
            <Route index element={<HomePage />}/>
        </Routes>
    </BrowserRouter>
  </StrictMode>,
)

function HomePage()
{
    return ( <main>
        <h1>Home Page</h1>
        </main>
    );
}
