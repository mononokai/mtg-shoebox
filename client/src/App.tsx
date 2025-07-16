import HomePage from "./pages/HomePage"
import SearchPage from "./pages/SearchPage"
import Layout from './layouts/Layout'
import { Routes, Route } from "react-router-dom"

function App() {
  return (
    <Layout>
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/search" element={<SearchPage />} />
      </Routes>
    </Layout>
  )
}

export default App
