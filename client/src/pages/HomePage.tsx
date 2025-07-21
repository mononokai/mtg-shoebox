import { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import styles from './HomePage.module.css';

export default function HomePage() {
  const [input, setInput] = useState<string>();
  const navigate = useNavigate();

  // Press "Enter" to navigate to search page with input value
  function handleKeyDown(event: React.KeyboardEvent<HTMLInputElement>) {
    if (event.key === "Enter") {
      navigate(`/search?q=${input}`);
    }
  }

  return (
    <div className={styles.homePage}>
      <h2 className={styles.homeTitle}>Welcome to MTG Shoebox</h2>
      <input
        type="search"
        placeholder="Search MTG Cards"
        className={styles.searchBar}
        onChange={e => setInput(e.target.value)}
        onKeyDown={handleKeyDown}
      />
      <p>
        Try searching <i>Lightning Bolt, Sliver, Lotus...</i>
      </p>
    </div>
  );
}
