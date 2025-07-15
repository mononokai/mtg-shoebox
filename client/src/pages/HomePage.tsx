import styles from './HomePage.module.css'

export default function HomePage() {
  return (
    <div className={styles.homePage}>
      <h2 className={styles.homeTitle}>Welcome to MTG Shoebox</h2>
      <input type="search" placeholder="Search MTG Cards" className={styles.searchBar} />
      <p>Try searching <i>Lightning Bolt, Sliver, Lotus...</i></p>
    </div>
  )
}